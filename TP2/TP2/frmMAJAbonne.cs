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
            abonnementBindingSource1.DataSource = lstAbonneDependant(lstAbonnePrincipal().First().Id);
        }

        private List<Abonnement> lstAbonnePrincipal() {
            List<Abonnement> lstAbonn = dataContext.Abonnements.Where(v => v.Id.Substring(v.Id.Length - 1, 1) == "P").ToList();
            return lstAbonn;
        }

        private List<Abonnement> lstAbonneDependant(String strAbonnePrincipalSelect)
        {
            List<Abonnement> lstAbonn = dataContext.Abonnements.Where(v => v.Id.Substring(0, strAbonnePrincipalSelect.Length-1)== strAbonnePrincipalSelect.Substring(0, strAbonnePrincipalSelect.Length - 1) && v.Id != strAbonnePrincipalSelect).ToList();
            return lstAbonn;
        }

        private void abonnementDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            abonnementBindingSource1.DataSource = lstAbonneDependant(dgAbonnementPrincipal.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (var porteeTransaction = new TransactionScope())
            {
                try
                {
                    dataContext.SubmitChanges();
                    MessageBox.Show("L'abonnée principal " + dgAbonnementPrincipal.CurrentRow.Cells[0].Value + " et ses dépendants ont été enregistrés.", "Enregistrement d'un abonnée");
                    porteeTransaction.Complete();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossible de modifier la base de donnée");
                }
            }
        }
    }
}
