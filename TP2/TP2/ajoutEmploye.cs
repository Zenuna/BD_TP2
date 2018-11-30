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
    public partial class ajoutEmploye : Form
    {
        DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
        public ajoutEmploye()
        {
            InitializeComponent();
            sexeBindingSource.DataSource = dataClasses1DataContext.Sexes;
            typesEmployeBindingSource.DataSource = dataClasses1DataContext.TypesEmployes;
            provinceBindingSource.DataSource = dataClasses1DataContext.Provinces;
            noTextBox.Text = (dataClasses1DataContext.Employes.Max(v => v.No)+1).ToString();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int noEmploye = int.Parse(noTextBox.Text);
            string strPrenom = prenomTextBox.Text;
            if(strPrenom.Trim().Length == 0)
            {
                errMessage.SetError(prenomTextBox, "Le prénom ne peut pas être vide");
            }
            string strNom = nomTextBox.Text;
            if (strNom.Trim().Length == 0)
            {
                errMessage.SetError(nomTextBox, "Le nom ne peut pas être vide");
            }
            string strMdeP = motDePasseTextBox.Text;
            if (strMdeP.Trim().Length == 0)
            {
                errMessage.SetError(prenomTextBox, "Le mot de passe ne peut pas être vide");
            }
            char chrSexe = sexeComboBox.SelectedValue.ToString().ToCharArray()[0];
            int intAge = 0;
            if(!int.TryParse(ageNumericUpDown.Value.ToString(),out intAge))
            {
                errMessage.SetError(ageNumericUpDown, "L'âge doit être un entier entre 16 et 65");
            }
            int intNoCivique = 0;
            if (!int.TryParse(noCiviqueTextBox.Text, out intNoCivique))
            {
                errMessage.SetError(noCiviqueTextBox, "Le numéro civique doit être un entier positif");
            }
            string strRue = rueTextBox.Text;
            if(strRue.Trim().Length == 0)
            {
                errMessage.SetError(rueTextBox, "La rue ne peut pas être vide");
            }
            string strVille = villeTextBox.Text;
            if (strVille.Trim().Length == 0)
            {
                errMessage.SetError(villeTextBox, "La ville ne peut pas être vide");
            }
            string strProvince = idProvinceComboBox.SelectedValue.ToString();
            string strCodePostal = codePostalMaskedTextBox.Text;
            if (strCodePostal.Trim().Length == 0)
            {
                errMessage.SetError(codePostalMaskedTextBox, "Le code postal ne peut pas être vide");
            }
            string strTelephone = telephoneTextBox.Text;
            if (strTelephone.Trim().Length == 0)
            {
                errMessage.SetError(telephoneTextBox, "Le numéro de téléphone ne peut pas être vide");
            }
            string strCellulaire = cellulaireMaskedTextBox.Text;
            string strCourriel = courrielMaskedTextBox.Text;
            if (strCourriel.Trim().Length == 0)
            {
                errMessage.SetError(courrielMaskedTextBox, "Le courriel ne peut pas être vide");
            }
            decimal dclMoney = 0;
            if(!decimal.TryParse(salaireHoraireTextBox.Text, out dclMoney))
            {
                errMessage.SetError(salaireHoraireTextBox, "Le salaire doit être un chiffre à deux décimal positif entre 10 et 500");
            }
            int intTypeEmploye = int.Parse(noTypeEmployeComboBox.SelectedValue.ToString());
            string strRemarque = remarqueTextBox.Text;
            Employe empAjouter = new Employe
            {
                No = int.Parse(noTextBox.Text)
            };
            this.Close();
        }
    }
}
