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
    public partial class frmAbonnement1 : Form

    {
        DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
        Employe empConnecter;
        public frmAbonnement1(Employe empConnect)
        {
            InitializeComponent();
            empConnecter = empConnect;
        }

        private void frmAbonnement_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = dataClasses1DataContext.TypesAbonnements;
            dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
            lblDateAbonnement.Text = DateTime.Now.Date.ToShortDateString();           
        }

        private void cmbTypeAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Int32.Parse(cmbTypeAbonnement.SelectedValue.ToString()) == 2)
            {
                dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-60);
                MessageBox.Show("Test", "Test");
            }
            else
            {
                dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
            }
        }
    }
}
