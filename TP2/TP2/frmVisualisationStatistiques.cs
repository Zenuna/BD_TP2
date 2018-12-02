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
    public partial class frmVisualisationStatistiques : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmVisualisationStatistiques(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmVisualisationStatistiques_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource1.DataSource = dataContext.TypesAbonnements.ToList();
            abonnementBindingSource.DataSource = recevoirStatsUn(int.Parse(dateTimeTabUn.Value.ToString().Substring(0, 4)), int.Parse(comboTypeAbonnementTabUn.SelectedValue.ToString()));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            abonnementBindingSource.DataSource = recevoirStatsUn(int.Parse(dateTimeTabUn.Value.ToString().Substring(0,4)), int.Parse(comboTypeAbonnementTabUn.SelectedValue.ToString()));
        }

        private void comboTypeAbonnementTabUn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
        private List<Abonnement> recevoirStatsUn(int annee,int noTypeAbonnement)
        {

            return dataContext.Abonnements.Where(v => v.DateAbonnement.Year == annee && v.NoTypeAbonnement == noTypeAbonnement).ToList();
        }

        private void comboTypeAbonnementTabUn_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboTypeAbonnementTabUn.SelectedValue == null)
            {
                abonnementBindingSource.DataSource = recevoirStatsUn(int.Parse(dateTimeTabUn.Value.ToString().Substring(0, 4)), 1);

            }
            else
            {
                abonnementBindingSource.DataSource = recevoirStatsUn(int.Parse(dateTimeTabUn.Value.ToString().Substring(0, 4)), int.Parse(comboTypeAbonnementTabUn.SelectedValue.ToString()));

            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            typesAbonnementBindingSource1.DataSource = dataContext.TypesAbonnements.ToList();
            abonnementBindingSource.DataSource = recevoirStatsUn(int.Parse(dateTimeTabUn.Value.ToString().Substring(0, 4)), int.Parse(comboTypeAbonnementTabUn.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
