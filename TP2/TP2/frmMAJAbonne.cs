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
            abonnementBindingSource1.DataSource = lstAbonneDependant(lstAbonnePrincipal().First().Id.Substring(0, lstAbonnePrincipal().First().Id.Length - 1));
        }

        private List<Abonnement> lstAbonnePrincipal() {
            List<Abonnement> lstAbonn = dataContext.Abonnements.Where(v => v.Id.Substring(v.Id.Length - 1, 1) == "P").ToList();
            return lstAbonn;
        }

        private List<Abonnement> lstAbonneDependant(String strAbonnePrincipalSelect)
        {
            List<Abonnement> lstAbonn = dataContext.Abonnements.Where(v => v.Id.Substring(0, strAbonnePrincipalSelect.Length)== strAbonnePrincipalSelect).ToList();
            return lstAbonn;
        }

        private void abonnementDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            abonnementBindingSource1.DataSource = lstAbonneDependant(dgAbonnementPrincipal.CurrentRow.Cells[0].Value.ToString().Substring(0, dgAbonnementPrincipal.CurrentRow.Cells[0].Value.ToString().Length - 1));
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
