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
    public partial class frmMenu : Form
    {
        Employe empConnect = null;
        public frmMenu(Employe empConnect)
        {
            InitializeComponent();
            this.empConnect = empConnect;

            int noTypeEmployeConnecter = empConnect.NoTypeEmploye;
            if(noTypeEmployeConnecter >= 5)
            {
                btnGestEmp.Enabled = false;
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMAJAbonne.Enabled = false;
                btnModifMontantAbonnement.Enabled = false;
                btnInscriptionPartieGolf.Enabled = false;
                btnVisualisationRapport.Enabled = false;
                btnVisualisationStats.Enabled = false;
            }
            else if(noTypeEmployeConnecter == 4)
            {
                btnGestEmp.Enabled = false;
                btnModifMontantAbonnement.Enabled = false;
                btnInscriptionDepense.Enabled = false;
                btnVisualisationRapport.Enabled = false;
                btnVisualisationStats.Enabled = false;
            }
            else if(noTypeEmployeConnecter == 2)
            {
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMAJAbonne.Enabled = false;
                btnInscriptionPartieGolf.Enabled = false;
            }
        }

        private void btnGestEmp_Click(object sender, EventArgs e)
        {
            frmGestionEmploye fGestionEmploye = new frmGestionEmploye(empConnect);
            this.Hide();
            fGestionEmploye.ShowDialog();
            this.Show();
        }

        private void btnAbonnement_Click(object sender, EventArgs e)
        {
            frmAbonnement fAbonnement= new frmAbonnement(empConnect);
            this.Hide();
            fAbonnement.ShowDialog();
            this.Show();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            frmReAbonnement fReAbonnement= new frmReAbonnement(empConnect);
            this.Hide();
            fReAbonnement.ShowDialog();
            this.Show();
        }

        private void btnMAJAbonne_Click(object sender, EventArgs e)
        {
            frmMAJAbonne fMAJAbonne = new frmMAJAbonne(empConnect);
            this.Hide();
            fMAJAbonne.ShowDialog();
            this.Show();
        }

        private void btnModifMontantAbonnement_Click(object sender, EventArgs e)
        {
            frmModifPrixDepAbonnement fModifPrixDepAbonnement= new frmModifPrixDepAbonnement(empConnect);
            this.Hide();
            fModifPrixDepAbonnement.ShowDialog();
            this.Show();
        }

        private void btnInscriptionPartieGolf_Click(object sender, EventArgs e)
        {
            frmInscriptionPartieGolf fInscriptionPartieGolf= new frmInscriptionPartieGolf(empConnect);
            this.Hide();
            fInscriptionPartieGolf.ShowDialog();
            this.Show();
        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            frmInscriptionDepense fInscriptionDepense = new frmInscriptionDepense(empConnect);
            this.Hide();
            fInscriptionDepense.ShowDialog();
            this.Show();
        }

        private void btnVisualisationRapport_Click(object sender, EventArgs e)
        {
            frmVisualisationRapport fVisualisationRapport = new frmVisualisationRapport(empConnect);
            this.Hide();
            fVisualisationRapport.ShowDialog();
            this.Show();
        }

        private void btnVisualisationStats_Click(object sender, EventArgs e)
        {
            frmVisualisationStatistiques fVisualisationStatistiques = new frmVisualisationStatistiques(empConnect);
            this.Hide();
            fVisualisationStatistiques.ShowDialog();
            this.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
