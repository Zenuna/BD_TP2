using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class frmGestionEmploye : Form
    {

        DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
        Employe empConnecte;
        public frmGestionEmploye(Employe empConnecte)
        {
            InitializeComponent();
            this.empConnecte = empConnecte;
        }

        private void frmGestionEmploye_Load(object sender, EventArgs e)
        {
            sexeBindingSource.DataSource = dataClasses1DataContext.Sexes;
            typesEmployeBindingSource.DataSource = dataClasses1DataContext.TypesEmployes;
            provinceBindingSource.DataSource = dataClasses1DataContext.Provinces;
            loadDataSource();
        }
       
        private void dgEmploye_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{10}$");
            DataGridViewRow dgRow = dgEmploye.Rows[e.RowIndex];
            int Age = 0;
            int noCivique = 0;
            if(e.FormattedValue.ToString().Trim().Equals("") && e.ColumnIndex != dgCellulaire.Index && e.ColumnIndex != dgCellulaire.Index)
            {
                dgRow.ErrorText = "Cette case ne peut pas être laissée vide";
                e.Cancel = true;
            }
            else 
            {
                if (e.ColumnIndex == dgAge.Index && !int.TryParse(e.FormattedValue.ToString(), out Age))
                {
                    dgRow.ErrorText = "L'âge doit être un entier positif";
                    e.Cancel = true;
                }
                else if (e.ColumnIndex == dgAge.Index)
                {
                    if (Age < 16 || Age > 65)
                    {
                        dgRow.ErrorText = "L'âge doit être entre 16 et 65 ans";
                        e.Cancel = true;
                    }
                }
                else if (e.ColumnIndex == dgNoCivique.Index && !int.TryParse(e.FormattedValue.ToString(), out noCivique))
                {
                    dgRow.ErrorText = "Le numéro civique doit être un entier supérier à 0";
                    e.Cancel = true;
                }
                else if((e.ColumnIndex == dgTelephone.Index || e.ColumnIndex == dgCellulaire.Index) && !regex.IsMatch(e.FormattedValue.ToString()))
                {
                    dgRow.ErrorText = "Le numéro de téléphone ou de cellulaire doit être 10 chiffres entre 0 et 9";
                    e.Cancel = true;
                }
                else if(e.ColumnIndex == dgSalaireHoraire.Index)
                {
                    Decimal dclMoney = 0;
                    if (!decimal.TryParse(e.FormattedValue.ToString().Replace('$', new Char()), out dclMoney))
                    {
                        dgRow.ErrorText = "Le salaire doit être un chiffre positif avec au maximum deux décimals";
                        e.Cancel = true;
                    }
                    else if(dclMoney > 500 || dclMoney < 10)
                    {
                        dgRow.ErrorText = "Le salaire doit être un montant entre 10 et 500 dollars";
                        e.Cancel = true;
                    }

                }
                else
                {
                    dgRow.ErrorText = "";
                    e.Cancel = false;
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgRow in dgEmploye.Rows)
            {
                int noEmp = 0;
                if (int.TryParse(dgRow.Cells[0].Value.ToString(), out noEmp))
                {
                    Employe emp = dataClasses1DataContext.Employes.Where(v => v.No == noEmp).First();
                    emp.No = int.Parse(dgRow.Cells[0].Value.ToString());
                    emp.MotDePasse = dgRow.Cells[1].Value.ToString();
                    emp.Nom = dgRow.Cells[2].Value.ToString();
                    emp.Prenom = dgRow.Cells[3].Value.ToString();
                    emp.Sexe = dgRow.Cells[4].Value.ToString().ToCharArray()[0];
                    emp.Age = int.Parse(dgRow.Cells[5].Value.ToString());
                    emp.NoCivique = int.Parse(dgRow.Cells[6].Value.ToString());
                    emp.Rue = dgRow.Cells[7].Value.ToString();
                    emp.Ville = dgRow.Cells[8].Value.ToString();
                    emp.IdProvince = dgRow.Cells[9].Value.ToString();
                    emp.Telephone = dgRow.Cells[10].Value.ToString();
                    if (dgRow.Cells[11].Value == null)
                    {
                        emp.Cellulaire = "";
                    }
                    else
                    {
                        emp.Cellulaire = dgRow.Cells[11].Value.ToString();
                    }
                    emp.Courriel = dgRow.Cells[12].Value.ToString();
                    emp.SalaireHoraire = decimal.Parse(dgRow.Cells[13].Value.ToString());
                    emp.NoTypeEmploye = int.Parse(dgRow.Cells[14].Value.ToString());
                    if (dgRow.Cells[15].Value == null)
                    {
                        emp.Remarque = "";
                    }
                    else
                    {
                        emp.Remarque = dgRow.Cells[15].Value.ToString();
                    }
                    try
                    {

                        dataClasses1DataContext.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier cet employé dans la base de donnée");
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajoutEmploye fAjoutEmp = new ajoutEmploye();
            this.Hide();
            fAjoutEmp.ShowDialog();
            this.Show();
        }

        private void btnSupprEmp_Click(object sender, EventArgs e)
        {
            int nbSelect = dgEmploye.SelectedRows.Count;
            foreach(DataGridViewRow dgRow in dgEmploye.SelectedRows)
            {
                int nbServices = dataClasses1DataContext.Services.Where(v => v.NoEmploye.ToString() == dgRow.Cells["dgNoEmploye"].ToString()).Count();
                if (!dgRow.Cells["dgTypeEmploye"].Value.ToString().Equals("1") && !dgRow.Cells["dgTypeEmploye"].Value.ToString().Equals(empConnecte.TypesEmploye.No.ToString()) && nbServices == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer " + dgRow.Cells["dgPrenom"].FormattedValue.ToString() + " " + dgRow.Cells["dgNom"].FormattedValue.ToString() + "?", "Supression d'un employé", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.OK)
                    {
                        Employe emp = dataClasses1DataContext.Employes.Where(v => v.No.ToString() == dgRow.Cells["dgNoEmploye"].Value.ToString()).First();
                        try
                        {
                            dataClasses1DataContext.Employes.DeleteOnSubmit(emp);
                            dataClasses1DataContext.SubmitChanges();
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Impossible de supprimer cet employé dans la base de donnée");
                        }
                    }
                }
                else if (!dgRow.Cells["dgTypeEmploye"].Value.ToString().Equals(empConnecte.TypesEmploye.No.ToString()))
                {
                    MessageBox.Show("Vous ne pouvez pas vous auto-supprimer", "Tentative d'auto-suppression");
                }
                else if(nbServices != 0)
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer un employé ayant un service lié", "Employé ayant un service");
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer l'administrateur", "Tentative de suppression de l'administrateur");
                }

            }
            loadDataSource();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataSource()
        {
            employeBindingSource.DataSource =
            from unEmploye in dataClasses1DataContext.Employes
            select unEmploye;
        }
    }
}

