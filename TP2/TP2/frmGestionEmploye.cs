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
    public partial class frmGestionEmploye : Form
    {
        DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
        public frmGestionEmploye(Employe empConnecte)
        {
            InitializeComponent();
        }

        private void frmGestionEmploye_Load(object sender, EventArgs e)
        {
            sexeBindingSource.DataSource = dataClasses1DataContext.Sexes;

            typesEmployeBindingSource.DataSource = dataClasses1DataContext.TypesEmployes;
            provinceBindingSource.DataSource = dataClasses1DataContext.Provinces;
            employeBindingSource.DataSource =
                from unEmploye in dataClasses1DataContext.Employes
                select unEmploye;
        }

    }
}
