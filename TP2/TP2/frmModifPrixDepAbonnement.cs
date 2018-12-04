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
namespace TP2
{
    public partial class frmModifPrixDepAbonnement : Form
    {

        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmModifPrixDepAbonnement(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmModifPrixDepAbonnement_Load(object sender, EventArgs e)
        {                      
            modPrixDepenseBindingSource2.DataSource = infoDepensesPrix(valideChangement());
            dgModPrixDep.Columns["prix"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgModPrixDep.Columns["depensesObligatoires"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (valideChangement() >= DateTime.Now.Year)
            {
                dgModPrixDep.ReadOnly = true;
                btnEnregistrer.Enabled = false;                
            }

        }
        private List<ModPrixDepense> infoDepensesPrix(int intAnneeRecente)
        {
            DateTime dateTime = DateTime.Now;
            List<PrixDepensesAbonnement> lstPrixDepenses = dataContext.PrixDepensesAbonnements.Where(v => v.Annee.Equals(intAnneeRecente)).ToList();            
            List<ModPrixDepense> lstAbonnVerif = new List<ModPrixDepense>();
            foreach (PrixDepensesAbonnement prixDepenses in lstPrixDepenses)
            {
                var lesDescriptions = from lesTypesAbonnements in dataContext.TypesAbonnements
                           where lesTypesAbonnements.No.Equals(prixDepenses.NoTypeAbonnement)
                           select lesTypesAbonnements;                     
                lstAbonnVerif.Add(new ModPrixDepense(lesDescriptions.First().No,lesDescriptions.First().Description, prixDepenses.Prix, prixDepenses.DepensesObligatoires));                
            }
            return lstAbonnVerif;
        }

        private int valideChangement()
        {                   
            List<PrixDepensesAbonnement> lst = dataContext.PrixDepensesAbonnements.OrderByDescending(v => v.Annee).ToList();
            int intAnneeRecente = lst.First().Annee;
            return intAnneeRecente;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        
                        foreach(DataGridViewRow dr in dgModPrixDep.Rows)
                        {
                            List<PrixDepensesAbonnement> lst = dataContext.PrixDepensesAbonnements.Where(v => v.NoTypeAbonnement.Equals(dr.Cells["no"].Value)).ToList();
                            var nouveauPrixDepenseAbon = new PrixDepensesAbonnement
                            {
                                NoTypeAbonnement = Convert.ToInt32(dr.Cells["no"].Value),
                                Annee = Convert.ToInt32(DateTime.Now.Year.ToString()),
                                Prix = Convert.ToDecimal(dr.Cells["prix"].Value),
                                DepensesObligatoires = Convert.ToDecimal(dr.Cells["depensesObligatoires"].Value),
                                Remarque = ""                                                              
                             };
                            dataContext.PrixDepensesAbonnements.InsertOnSubmit(nouveauPrixDepenseAbon);
                            
                            /*foreach (PrixDepensesAbonnement prixDepAbonn in lst)
                            {
                                prixDepAbonn.DepensesObligatoires = Convert.ToDecimal(dr.Cells["depensesObligatoires"].Value);
                                prixDepAbonn.Prix = Convert.ToDecimal(dr.Cells["prix"].Value);
                                prixDepAbonn.Annee = Convert.ToInt32(DateTime.Now.Year.ToString());
                                //dataContext.PrixDepensesAbonnements.InsertOnSubmit()
                            }*/
                        }
                                       
                       
                        dataContext.SubmitChanges();
                       MessageBox.Show("Les prix et les dépenses ont étés modifiés pour l'année " + DateTime.Now.Year +
                           "\n\nLes prochaines modifications pourront être effectué en 2019 ", "Enregistrement des prix et des dépenses");
                        porteeTransaction.Complete();
                        dgModPrixDep.ReadOnly = true;
                        btnEnregistrer.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de donnée");
                    }
                }
            }
        }

        private void dgModPrixDep_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow dgRow = dgModPrixDep.Rows[e.RowIndex];
            string strPrix = dgRow.Cells["prix"].EditedFormattedValue.ToString().Replace("$","");
            string strDepense = dgRow.Cells["depensesObligatoires"].EditedFormattedValue.ToString().Replace("$", "");

            decimal decNumber;           
            if (e.FormattedValue.ToString().Trim().Equals(""))
            {
                dgRow.ErrorText = "Cette case ne peut pas être laisée vide";
                e.Cancel = true;
            }else if (!Decimal.TryParse(strPrix, out decNumber))
            {
                dgRow.ErrorText = "Cette case peut uniquement contenir des chiffres (999.9999)";
                e.Cancel = true;
            }else if (!Decimal.TryParse(strDepense, out decNumber))
            {
                dgRow.ErrorText = "Cette case peut uniquement contenir des chiffres (999.9999)";
                e.Cancel = true;
            }
            else
            {
                dgRow.ErrorText = "";
            }
        }

        private void frmModifPrixDepAbonnement_Shown(object sender, EventArgs e)
        {
            if (valideChangement() >= DateTime.Now.Year)         
                MessageBox.Show("Les modifications des prix et des dépenses\n ont déjà été effectuées pour l'année " + DateTime.Now.Year, "Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Information);
                          
        }
    }
}
