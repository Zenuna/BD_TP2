using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
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
            Regex regexCodePostal = new Regex(@"^([A-Z][0-9]){3}$");
            DataGridViewRow dgRow = dgEmploye.Rows[e.RowIndex];
            int Age = 0;
            if(e.FormattedValue.ToString().Trim().Equals("") && e.ColumnIndex != dgCellulaire.Index && e.ColumnIndex != dgRemarque.Index)
            {
                dgRow.ErrorText = "Cette case ne peut pas être laissée vide";
                e.Cancel = true;
            }
            else 
            {
                if (e.ColumnIndex == dgCodePostal.Index)
                {
                    if (!regexCodePostal.IsMatch(e.FormattedValue.ToString().ToUpper()))
                    {
                        dgRow.ErrorText = "Le code postal doit être de format : L#L#L#";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgRow.ErrorText = "";
                    }
                }
                else if (e.ColumnIndex == dgAge.Index)
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out Age))
                    {

                        dgRow.ErrorText = "L'âge doit être un entier positif";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgRow.ErrorText = "";
                    }
                }
                else if (e.ColumnIndex == dgAge.Index)
                {
                    if (Age < 16 || Age > 65)
                    {
                        dgRow.ErrorText = "L'âge doit être entre 16 et 65 ans";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgRow.ErrorText = "";
                    }
                }
                else if(e.ColumnIndex == dgTelephone.Index)
                {
                    if (!regex.IsMatch(e.FormattedValue.ToString()))
                    {
                        dgRow.ErrorText = "Le numéro de téléphone doit être 10 chiffres entre 0 et 9 | Format : ##########";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgRow.ErrorText = "";
                    }

                }
                else if(e.ColumnIndex == dgCellulaire.Index && e.FormattedValue.ToString().Trim().Length > 0) {
                    if (!regex.IsMatch(e.FormattedValue.ToString()))
                    {
                        dgRow.ErrorText = "Le numéro de cellulaire doit être 10 chiffres entre 0 et 9 | Format : ##########";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgRow.ErrorText = "";
                    }

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
                    else
                    {
                        dgRow.ErrorText = "";
                    }

                }
                else if(e.ColumnIndex == dgMdeP.Index)
                {
                    bool blnChiffre = false;
                    bool blnLettre = false;
                    bool blnAutre = false;
                    string strMdeP = e.FormattedValue.ToString().Trim();
                    if (strMdeP.Length < 8)
                    {
                        dgRow.ErrorText = "Le mot de passe est composé au minimum de 8 charactères";
                        e.Cancel = true;
                    }
                    else
                    {
                        char[] lstChar = strMdeP.ToCharArray();
                        foreach (char c in lstChar)
                        {
                            if (Char.IsDigit(c))
                            {
                                blnChiffre = true;
                            }
                            else if (Char.IsLetter(c))
                            {
                                blnLettre = true;
                            }
                            else
                            {
                                blnAutre = true;
                            }
                        }
                        if (!blnChiffre || !blnLettre || !blnAutre)
                        {
                            dgRow.ErrorText = "Le mot de passe doit contenir une lettre, un chiffre et un autre caractère";
                            e.Cancel = true;
                        }
                        else
                        {
                            dgRow.ErrorText = "";
                        }
                    }
                }
                else if(e.ColumnIndex == dgCourriel.Index)
                {
                    string strCourriel = e.FormattedValue.ToString().Trim();
                        if (!strCourriel.Contains("@"))
                        {
                            dgRow.ErrorText = "Le courriel doit contenir un '@' | Format : LLLLLL@LLL.LLL";
                            e.Cancel = true;
                        }
                        else
                        {
                            string strCourrielPartDeux = strCourriel.Split('@')[1];
                            if (strCourrielPartDeux.Contains("@"))
                            {
                                dgRow.ErrorText = "Le courriel ne doit pas contenir deux '@' | Format : LLLLLL@LLL.LLL";
                                e.Cancel = true;
                            }
                            else if (strCourrielPartDeux.Contains("."))
                            {
                                string strCourrielPartTrois = strCourrielPartDeux.Split('.')[1];
                                if (strCourrielPartTrois.Contains("."))
                                {
                                    dgRow.ErrorText = "Le courriel ne doit pas contenir deux domaines de premier niveau | Format : LLLLLL@LLL.LLL";
                                    e.Cancel = true;
                                }
                                else
                                {
                                    dgRow.ErrorText = "";
                                }
                            }
                            else
                            {
                                dgRow.ErrorText = "Le courriel doit contenir un domaine de premier niveau | Format : LLLLLL@LLL.LLL";
                                e.Cancel = true;
                            }
                        }
                    }
                else
                {
                    dgRow.ErrorText = "";
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                try
                {
                    dataClasses1DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                    MessageBox.Show(this, "Informations modifiées", "Enregistrement");
                }
                catch (ChangeConflictException)
                {
                    dataClasses1DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajoutEmploye fAjoutEmp = new ajoutEmploye();
            this.Hide();
            fAjoutEmp.ShowDialog();
            loadDataSource();
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
                            dataClasses1DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                            loadDataSource();
                        }
                        catch (ChangeConflictException)
                        {
                            dataClasses1DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur lors de la suppression des données");
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

