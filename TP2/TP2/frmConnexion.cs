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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            String strNo = tbNoEmp.Text;
            int noEmp;
            if (int.TryParse(strNo,out noEmp))
            {
                List<Employe> lstEmp = dataClasses1DataContext.Employes.Where(v => v.No == noEmp).ToList();
                if(lstEmp.Count <= 0)
                {
                    lblErreurConnexion.Text = "Numéro d'employé inconnu";
                    lblErreurConnexion.Location = positionMessage(this.Width, lblErreurConnexion.Width, lblErreurConnexion.Location.Y);
                    lblErreurConnexion.Visible = true;
                }
                else
                {
                    if (lstEmp[0].MotDePasse == tbMdeP.Text)
                    {
                        lblErreurConnexion.Visible = false;
                        tbNoEmp.Text = "";
                        tbMdeP.Text = "";
                        frmMenu fMenu = new frmMenu(lstEmp[0]);
                        this.Hide();
                        fMenu.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        lblErreurConnexion.Text = "Mauvaise combinaison";
                        lblErreurConnexion.Location = positionMessage(this.Width,lblErreurConnexion.Width,lblErreurConnexion.Location.Y);
                        lblErreurConnexion.Visible = true;
                    }

                }

            }
            else
            {
                lblErreurConnexion.Text = "Le numéro d'employé doit être un entier positif";
                lblErreurConnexion.Location = positionMessage(this.Width, lblErreurConnexion.Width, lblErreurConnexion.Location.Y);
                lblErreurConnexion.Visible = true;
            }
        }
        public Point positionMessage(int largeurPage, int largeurMessage, int yMessage) {
            Point p = new Point(largeurPage / 2 - largeurMessage / 2, yMessage);
            return p;
        }
    }

}
