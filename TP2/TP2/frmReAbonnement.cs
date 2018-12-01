using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class frmReAbonnement : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmReAbonnement(Employe empConnect)
        {
            InitializeComponent();
        }

        private void frmReAbonnement_Load(object sender, EventArgs e)
        {
            abonnementBindingSource.DataSource = loadDG();
        }

        private void btnRenouveler_Click(object sender, EventArgs e)
        {
            Reabonnement rAb = new Reabonnement();
            rAb.IdAbonnement = dgAbonnement.CurrentRow.Cells[0].Value.ToString();
            rAb.DateRenouvellement = DateTime.Now.Date;
            rAb.Remarque = tbRemarque.Text.Trim();
            try
            {
                dataContext.Reabonnements.InsertOnSubmit(rAb);
                dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                abonnementBindingSource.DataSource = loadDG();
            }
            catch (ChangeConflictException)
            {
                dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout des données");
            }
        }

        private List<Abonnement> loadDG()
        {
            bool blnRetirer = false;
            DateTime dateTime = DateTime.Now;
            List<Abonnement> lstAbonn = dataContext.Abonnements.Where(v => v.DateAbonnement.AddYears(1) <= dateTime && v.Id.Substring(v.Id.Length - 1, 1) == "P").ToList();
            List<Abonnement> lstAbonnVerif = new List<Abonnement>();
            foreach (Abonnement abb in lstAbonn)
            {
                if (dataContext.Reabonnements.Where(v => v.IdAbonnement == abb.Id && v.DateRenouvellement.AddYears(1) >= dateTime).Count() == 0)
                {
                    lstAbonnVerif.Add(abb);
                }
            }
            return lstAbonnVerif;
        }

        private void btbRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
