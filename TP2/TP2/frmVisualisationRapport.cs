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
    public partial class frmVisualisationRapport : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmVisualisationRapport(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmVisualisationRapport_Load(object sender, EventArgs e)
        {
            tabPage1_Enter(sender, e);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            RapportDepensesEmployeBindingSource.DataSource = from lesDepenses in dataContext.Depenses
                                                             select new
                                                             {
                                                                 nomCompletEmploye = lesDepenses.Service.Employe.Nom + ", " + lesDepenses.Service.Employe.Prenom,
                                                                 typeService = lesDepenses.Service.TypeService,
                                                                 montant = Convert.ToDecimal(lesDepenses.Montant),
                                                                 dateDepense = lesDepenses.DateDepense,
                                                                 nomCompletAbPrincipal = lesDepenses.Abonnement.Nom + ", " + lesDepenses.Abonnement.Prenom,
                                                             };
            this.rappDepEmploy.RefreshReport();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            RapportDepensesEmployeBindingSource.DataSource = from lesDepenses in dataContext.Depenses
                                                             select new
                                                             {
                                                                 nomCompletEmploye = lesDepenses.Service.Employe.Nom + ", " + lesDepenses.Service.Employe.Prenom,
                                                                 typeService = lesDepenses.Service.TypeService,
                                                                 montant = Convert.ToDecimal(lesDepenses.Montant),
                                                                 dateDepense = lesDepenses.DateDepense,
                                                                 nomCompletAbPrincipal = lesDepenses.Abonnement.Nom + ", " + lesDepenses.Abonnement.Prenom,
                                                             };
            this.rappDepAbonn.RefreshReport();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            DepensesParAnneeBindingSource.DataSource = from lesDepenses in dataContext.Depenses
                                                       select new
                                                       {
                                                           annee = lesDepenses.DateDepense.Year,
                                                           nomCompletEmploye = lesDepenses.Service.Employe.Nom + ", " + lesDepenses.Service.Employe.Prenom,
                                                           typeService = lesDepenses.Service.TypeService,
                                                           montant = Convert.ToDecimal(lesDepenses.Montant),
                                                           dateDepense = lesDepenses.DateDepense,
                                                           nomCompletAbPrincipal = lesDepenses.Abonnement.Nom + ", " + lesDepenses.Abonnement.Prenom,
                                                       };
            this.rapDepAnnee.RefreshReport();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            PartiesJoueesTerrainBindingSource.DataSource = from lesParties in dataContext.PartiesJouees
                                                           join lesTerrains in dataContext.Terrains
                                                           on lesParties.NoTerrain equals lesTerrains.No
                                                           join lesAbonnes in dataContext.Abonnements
                                                           on lesParties.IdAbonnement equals lesAbonnes.Id
                                                           select new
                                                           {
                                                               nomTerrain = lesTerrains.Nom,
                                                               nomAbonnePrincipal = lesAbonnes.Nom + ", " + lesAbonnes.Prenom,
                                                               datePartie = lesParties.DatePartie,
                                                               pointage = lesParties.Pointage

                                                           };
            this.rappPartieJoueeTerrain.RefreshReport();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            PartiesJoueesTerrainBindingSource.DataSource = from lesParties in dataContext.PartiesJouees
                                                           join lesTerrains in dataContext.Terrains
                                                           on lesParties.NoTerrain equals lesTerrains.No
                                                           join lesAbonnes in dataContext.Abonnements
                                                           on lesParties.IdAbonnement equals lesAbonnes.Id
                                                           select new
                                                           {
                                                               nomTerrain = lesTerrains.Nom,
                                                               nomAbonnePrincipal = lesAbonnes.Nom + ", " + lesAbonnes.Prenom,
                                                               datePartie = lesParties.DatePartie,
                                                               pointage = lesParties.Pointage

                                                           };
            this.reportViewer1.RefreshReport();
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            PartieJoueesAnneeBindingSource.DataSource = from PartiesJouees in dataContext.PartiesJouees
                                                        select new
                                                        {
                                                            Annee = Convert.ToInt32(PartiesJouees.DatePartie.Year),
                                                            datePartie = PartiesJouees.DatePartie,
                                                            nomTerrain = PartiesJouees.Terrain.Nom,
                                                            nomAbonnePrincipal = (PartiesJouees.Abonnement.Nom + ", " + PartiesJouees.Abonnement.Prenom),
                                                            pointage = PartiesJouees.Pointage
                                                        };
            this.rapportPartiesJoueesAnnee.RefreshReport();
        }
    }
}
