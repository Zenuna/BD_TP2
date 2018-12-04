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
    public partial class frmInformationsDepenses : Form
    {
        Depense depenseInfo = null;
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmInformationsDepenses(Depense depenseAjoute)
        {
            InitializeComponent();
            depenseInfo = depenseAjoute;
        }

        private void frmInformationsDepenses_Load(object sender, EventArgs e)
        {
            informationDepensesBindingSource.DataSource = InfoDepense();
            montantTextBox.AppendText(" $");
            montantExigerTextBox.AppendText(" $");
            montantEffectuerTextBox.AppendText(" $");
        }

        private InformationDepenses InfoDepense()
        {
            decimal montantEff = dataContext.Depenses.Where(v => v.IdAbonnement.Equals(depenseInfo.IdAbonnement)).Sum(s => s.Montant);
            PrixDepensesAbonnement prixExiger = dataContext.PrixDepensesAbonnements.Where( c => c.TypesAbonnement.Equals(depenseInfo.Abonnement.TypesAbonnement)).First();
            decimal calculExiger = prixExiger.DepensesObligatoires - montantEff;
            if(calculExiger < 0)
            {
                calculExiger = 0;
            }
            InformationDepenses unInfoDepenses = new InformationDepenses
            {
                 montantEffectuer = (montantEff - depenseInfo.Montant),
                montantExiger = calculExiger,
                nomCompletEmploye = depenseInfo.Service.Employe.Nom + ", "+depenseInfo.Service.Employe.Prenom,
                typeService = depenseInfo.Service.TypeService,
                montant = depenseInfo.Montant,
                 dateDepense = depenseInfo.DateDepense,
                nomCompletAbPrincipal = depenseInfo.Abonnement.Nom+", "+ depenseInfo.Abonnement.Prenom
        };
            lblDateDepense.Text = unInfoDepenses.dateDepense.ToShortDateString();
          
       

            return unInfoDepenses;
        }
    }
}
