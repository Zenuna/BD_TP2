using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
            int terrain = 1;
            if(cmbTerrain.SelectedValue != null)
            {
                terrain = int.Parse(cmbTerrain.SelectedValue.ToString());
            }

            List < nomCompletIDAbonne > lstNomIDValides = new List<nomCompletIDAbonne>();
            foreach (var prixDepenses in test)
            {
                var verif = from unePartie in dataContext.PartiesJouees
                            where
                            unePartie.DatePartie == dateTime &&
                            unePartie.IdAbonnement == prixDepenses.Id &&
                            unePartie.NoTerrain == terrain
                            select unePartie;
                if(verif.Count()==0) lstNomIDValides.Add(new nomCompletIDAbonne(prixDepenses.Id,prixDepenses.Id.PadRight(8, ' ') + " => "+prixDepenses.Prenom +" "+ prixDepenses.Nom));
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


            try
            {
                dataContext.PartiesJouees.InsertOnSubmit(nouvelPartie);
                dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                MessageBox.Show($"La partie jouée le {lblDatePartie.Text} par {cmbAbonne.SelectedValue.ToString()} a été enregistrée", "Enregistrement d'une partie jouée", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            catch (ChangeConflictException)
            {
                dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'enregistrement de la partie a échouée" + ex, "Enregistrement de l'abonné principal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            nomCompletIDAbonneBindingSource.DataSource = infoIDetNom();
        }

        private void cmbTerrain_SelectedValueChanged(object sender, EventArgs e)
        {
            nomCompletIDAbonneBindingSource.DataSource = infoIDetNom();
        }

        private void noTerrainLabel_Click(object sender, EventArgs e)
        {

        }

        private void idEtNomCompletLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
