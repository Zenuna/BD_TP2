using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace TP2
{
    public partial class frmInscriptionDepense : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        Employe empconnecter;
        public frmInscriptionDepense(Employe empConnect)
        {
            InitializeComponent();
            empconnecter = empConnect;
        }

        private void frmInscriptionDepense_Load(object sender, EventArgs e)
        {
            nomCompletIDAbonneBindingSource.DataSource = infoIDetNom();
            serviceBindingSource.DataSource = dataContext.Services.GroupBy(c => c.TypeService);
            lblDateDepense.Text = DateTime.Now.Date.ToShortDateString();        
          
            if (Convert.ToInt32(empconnecter.NoTypeEmploye) == 1 || Convert.ToInt32(empconnecter.NoTypeEmploye) == 2 || Convert.ToInt32(empconnecter.NoTypeEmploye) == 3)
            {
                cmbTypeService.Items.Add("Magasin Pro Shop");
                cmbTypeService.Items.Add("Restaurant");
                cmbTypeService.Items.Add("Leçon de golf");
                cmbTypeService.SelectedIndex = 0;
                cmbTypeService.Visible = true;
                lblService.Visible = true;
                
            }
        }
        private List<nomCompletIDAbonne> infoIDetNom()
        {
            DateTime dateTime = DateTime.Now;

            var test = from Abonnements in dataContext.Abonnements                      
                       select Abonnements;

            List<nomCompletIDAbonne> lstNomIDValides = new List<nomCompletIDAbonne>();
            foreach (var prixDepenses in test)
            {
                lstNomIDValides.Add(new nomCompletIDAbonne(prixDepenses.Id, prixDepenses.Id.PadRight(8, ' ') + " => " + prixDepenses.Prenom + " " + prixDepenses.Nom));
            }

            return lstNomIDValides;
        }

        private Service ajouteService(string strTypeService)
        {
            int intNoService = dataContext.Services.Count() + 1;
            var unNouveauService = new Service
            {
                No = intNoService,
                TypeService = strTypeService,
                NoEmploye = empconnecter.No,
                Remarque = remarqueTextBox.Text
            };         
            return unNouveauService;
        }

        private Depense ajouteDepense(int noService)
        {
            int noDepense = dataContext.Depenses.Count() + 1;
            var nouvelDepense = new Depense
            {
                No = noDepense,
                IdAbonnement = cmbAbonnePrincipal.SelectedValue.ToString(),
                DateDepense = Convert.ToDateTime(lblDateDepense.Text),
                Montant = montantNumberPick.Value,
                NoService = noService,
                Remarque = remarqueTextBox.Text
            };           
            return nouvelDepense;
        }

        private void btnAjoutDepense_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
               
                List<Service> service = new List<Service>();
                Service serviceSelect = null;
                Service serviceAjoute = null;
                Depense depenseAjoute = null;
                if (Convert.ToInt32(empconnecter.NoTypeEmploye) != 1 && Convert.ToInt32(empconnecter.NoTypeEmploye) != 2 && Convert.ToInt32(empconnecter.NoTypeEmploye) != 3)
                {
                    string[] strTypesService = { "Magasin Pro Shop", "Restaurant", "Leçon de golf" };
                    string strTypeSelect = empconnecter.NoTypeEmploye.Equals(5) ? strTypesService[0] : empconnecter.NoTypeEmploye.Equals(6) ? strTypesService[1] : empconnecter.NoTypeEmploye.Equals(7) ? strTypesService[2] : "";
                    service = dataContext.Services.Where(c => c.NoEmploye.Equals(empconnecter.No)).Where(v => v.TypeService.Equals(strTypeSelect)).ToList();
                    if (service.Count > 0)
                    {
                        serviceSelect = service.First();
                        depenseAjoute = ajouteDepense(serviceSelect.No);
                    }                        
                    else
                    {
                        serviceAjoute = ajouteService(strTypeSelect);
                        depenseAjoute = ajouteDepense(serviceAjoute.No);

                    }
                }
                else
                {
                    service = dataContext.Services.Where(c => c.NoEmploye.Equals(empconnecter.No)).Where(v => v.TypeService.Equals(cmbTypeService.SelectedItem)).ToList();
                    if (service.Count > 0)
                    {
                        serviceSelect = service.First();
                        depenseAjoute =  ajouteDepense(serviceSelect.No);
                    }                      
                    else
                    {
                        serviceAjoute = ajouteService(cmbTypeService.SelectedItem.ToString());
                        depenseAjoute = ajouteDepense(serviceAjoute.No);
                    }
                }

                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {                       
                        string strMessage = "La dépense a été ajouté";
                        if (serviceAjoute != null)
                        {
                            dataContext.Services.InsertOnSubmit(serviceAjoute);                            
                            strMessage += " et le service a été ajouté.";
                        }
                        if (depenseAjoute != null)                              
                            dataContext.Depenses.InsertOnSubmit(depenseAjoute);                                             
                                                
                        dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                        porteeTransaction.Complete();
                        MessageBox.Show(strMessage, "Enregistrement d'une dépense", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                    }
                    catch (ChangeConflictException)
                    {
                        dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La dépense n'a pas été ajouté"+ex, "Enregistrement d'une dépense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                this.Hide();
                frmInformationsDepenses frm = new frmInformationsDepenses(depenseAjoute);
                frm.ShowDialog();


            }
        }

    }
}
