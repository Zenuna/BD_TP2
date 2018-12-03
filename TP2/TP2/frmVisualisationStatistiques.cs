using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class frmVisualisationStatistiques : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmVisualisationStatistiques(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmVisualisationStatistiques_Load(object sender, EventArgs e)
        {
            AbonneStatsBindingSource.DataSource = from unAbonnement in dataContext.Abonnements
                                                  select new
                                                  {
                                                      nbAbonnee = 1,
                                                      typeAbonnement = recevoirDescriptionAbonnement(unAbonnement.NoTypeAbonnement),
                                                      Annee = unAbonnement.DateAbonnement.Year
                                                  };
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String recevoirDescriptionAbonnement(int no)
        {
            return dataContext.TypesAbonnements.Where(v => v.No == no).First().Description;
        }

        private String recevoirTerrain(int no)
        {
            return dataContext.Terrains.Where(v => v.No == no).First().Nom;
        }

        private String recevoirMoisAvecMaj(String strMois)
        {
            return strMois.Substring(0, 1).ToUpper() + strMois.Substring(1, strMois.Length-1);
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AbonneStatsBindingSource.DataSource = from unAbonnement in dataContext.Abonnements
                                                  select new
                                                  {
                                                      nbAbonnee = 1,
                                                      typeAbonnement = recevoirDescriptionAbonnement(unAbonnement.NoTypeAbonnement),
                                                      Annee = unAbonnement.DateAbonnement.Year
                                                  };
            this.reportViewer1.RefreshReport();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

            AbonneStatsBindingSource.DataSource = from unAbonnement in dataContext.Abonnements.Where(v=> v.DateAbonnement.Year == DateTime.Now.Year)
                                                  select new
                                                  {
                                                      nbAbonnee = 1,
                                                      typeAbonnement = recevoirDescriptionAbonnement(unAbonnement.NoTypeAbonnement),
                                                      Mois = recevoirMoisAvecMaj(unAbonnement.DateAbonnement.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr")))
                                                  };
            this.reportViewer2.RefreshReport();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            PartiesJoueesStatsBindingSource.DataSource = from unePartieJouee in dataContext.PartiesJouees
                                                         select new
                                                         {
                                                             idAbonnement = unePartieJouee.IdAbonnement,
                                                             nomTerrain = recevoirTerrain(unePartieJouee.NoTerrain),
                                                             Annee = unePartieJouee.DatePartie.Year
                                                         };
            this.reportViewer3.RefreshReport();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            PartiesJoueesStatsBindingSource.DataSource = from unePartieJouee in dataContext.PartiesJouees.Where(v => v.DatePartie.Year == DateTime.Now.Year)
                                                         select new
                                                         {
                                                             idAbonnement = unePartieJouee.IdAbonnement,
                                                             nomTerrain = recevoirTerrain(unePartieJouee.NoTerrain),
                                                             Mois = recevoirMoisAvecMaj(unePartieJouee.DatePartie.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr")))
                                                         };
            this.reportViewer4.RefreshReport();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            DepenseStatsBindingSource.DataSource = from uneDepense in dataContext.Depenses
                                                   select new
                                                   {
                                                       idAbonnement = uneDepense.IdAbonnement,
                                                       montant = uneDepense.Montant,
                                                       Annee = uneDepense.DateDepense.Year
                                                   };
            this.reportViewer5.RefreshReport();
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            DepenseStatsBindingSource.DataSource = from uneDepense in dataContext.Depenses.Where(v=> v.DateDepense.Year == DateTime.Now.Year)
                                                   select new
                                                   {
                                                       idAbonnement = uneDepense.IdAbonnement,
                                                       montant = uneDepense.Montant,
                                                       Mois = recevoirMoisAvecMaj(uneDepense.DateDepense.ToString("MMMM", CultureInfo.CreateSpecificCulture("fr")))
                                                   };
            this.reportViewer6.RefreshReport();
        }
    }
}
