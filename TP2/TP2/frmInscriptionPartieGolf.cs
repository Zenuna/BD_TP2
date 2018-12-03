using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class frmInscriptionPartieGolf : Form
    {

        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmInscriptionPartieGolf(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmInscriptionPartieGolf_Load(object sender, EventArgs e)
        {
            terrainBindingSource.DataSource = dataContext.Terrains;
            lblDatePartie.Text = DateTime.Now.Date.ToShortDateString();
            nomCompletIDAbonneBindingSource.DataSource = infoIDetNom();
        }

        private List<nomCompletIDAbonne> infoIDetNom()
        {
            DateTime dateTime = DateTime.Now;          

            var test = from Abonnements in dataContext.Abonnements
                       join Reabonnements in dataContext.Reabonnements on Abonnements.Id equals Reabonnements.IdAbonnement into lesAbonnesValides
                       from Reabonnements in lesAbonnesValides.DefaultIfEmpty()
                       where
                         Abonnements.DateAbonnement > DateTime.Now.Date.AddYears(-1) ||
                        Reabonnements.DateRenouvellement > DateTime.Now.Date.AddYears(-1)
                       select Abonnements;
            
            List <nomCompletIDAbonne> lstNomIDValides = new List<nomCompletIDAbonne>();
            foreach (var prixDepenses in test)
            {                
                lstNomIDValides.Add(new nomCompletIDAbonne(prixDepenses.Id,prixDepenses.Id.PadRight(8, ' ') + " => "+prixDepenses.Prenom +" "+ prixDepenses.Nom));
            }

            return lstNomIDValides;
        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {
            var nouvelPartie = new PartiesJouee
            {
                IdAbonnement = cmbAbonne.SelectedValue.ToString(),
                NoTerrain = Convert.ToInt32(cmbTerrain.SelectedValue),
                DatePartie = Convert.ToDateTime(lblDatePartie.Text),
                Pointage = Convert.ToInt32(nUDPointage.Value),
                Remarque = remarqueTextBox.Text
            };

            dataContext.PartiesJouees.InsertOnSubmit(nouvelPartie);
            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show($"La partie jouée le {lblDatePartie.Text} par {cmbAbonne.SelectedValue.ToString()} a été enregistrée", "Enregistrement d'une partie jouée", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'enregistrement de la partie a échouée" + ex, "Enregistrement de l'abonné principal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
