using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.Text.RegularExpressions;
using System.Data.Linq;

namespace TP2
{
    public partial class frmMAJAbonne : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmMAJAbonne(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmMAJAbonne_Load(object sender, EventArgs e)
        {
            sexeBindingSource.DataSource = dataContext.Sexes;
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnements;
            provinceBindingSource.DataSource = dataContext.Provinces;
            abonnementBindingSource.DataSource = lstAbonnePrincipal();
            dependantBindingSource.DataSource = lstAbonneDependant(lstAbonnePrincipal().First().Id);
        }

        private List<Abonnement> lstAbonnePrincipal()
        {
            return dataContext.Abonnements.ToList(); ;
        }

        private List<Dependant> lstAbonneDependant(String strAbonnePrincipalSelect)
        {
            return dataContext.Dependants.Where(v => v.IdAbonnement == strAbonnePrincipalSelect).ToList();
        }

        private void abonnementDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dependantBindingSource.DataSource = lstAbonneDependant(dgAbonnementPrincipal.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                        MessageBox.Show("Données enregistrées","Sauvegarde des données");
                        porteeTransaction.Complete();
                    }
                catch (ChangeConflictException)
                {
                        dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de donnée");
                    }
                }
            }
        }

        private void dependantDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow dgRow = dependantDataGridView.Rows[e.RowIndex];
            if (e.FormattedValue.ToString().Trim().Equals("") && e.ColumnIndex != dgRemarqueDep.Index)
            {
                dgRow.ErrorText = "Cette case ne peut pas être laisée vide";
                e.Cancel = true;
            }
            else
            {
                dgRow.ErrorText = "";
            }
        }

        private void dgAbonnementPrincipal_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{10}$");
            DataGridViewRow dgRow = dgAbonnementPrincipal.Rows[e.RowIndex];
            if (e.FormattedValue.ToString().Trim().Equals("") && e.ColumnIndex != dgRemarque.Index && e.ColumnIndex != dgCellulaire.Index)
            {
                dgRow.ErrorText = "Cette case ne peut pas être laisée vide";
                e.Cancel = true;
            }
            else
            {
                if (e.ColumnIndex == dgTelephone.Index)
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
                else if (e.ColumnIndex == dgCellulaire.Index && e.FormattedValue.ToString().Trim().Length > 0)
                {
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
                else if (e.ColumnIndex == dgCourriel.Index)
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
    }
}
