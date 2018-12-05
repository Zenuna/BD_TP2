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
            if (this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                int noEmploye = int.Parse(noTextBox.Text);
                string strPrenom = prenomTextBox.Text;
                string strNom = nomTextBox.Text;
                string strMdeP = motDePasseTextBox.Text;
                char chrSexe = sexeComboBox.SelectedValue.ToString().ToCharArray()[0];
                int intAge = int.Parse(ageNumericUpDown.Value.ToString());
                string strNoCivique = noCiviqueTextBox.Text;
                string strRue = rueTextBox.Text;
                string strVille = villeTextBox.Text;
                string strProvince = idProvinceComboBox.SelectedValue.ToString();
                string strCodePostal = codePostalMaskedTextBox.Text.Replace(" ", "");
                string strTelephone = telephoneMaskedTextBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
                string strCellulaire = cellulaireMaskedTextBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
                string strCourriel = courrielTextBox.Text;
                decimal dclMoney = decimal.Parse(salaireHoraireNumericUpDown.Value.ToString());
                int intTypeEmploye = int.Parse(noTypeEmployeComboBox.SelectedValue.ToString());
                string strRemarque = remarqueTextBox.Text;
                Employe empAjouter = new Employe
                {
                    No = int.Parse(noTextBox.Text),
                    MotDePasse = strMdeP,
                    Prenom = strPrenom,
                    Nom = strNom,
                    Sexe = chrSexe,
                    Age = intAge,
                    NoCivique = strNoCivique,
                    Rue = strRue,
                    Ville = strVille,
                    IdProvince = strProvince,
                    CodePostal = strCodePostal,
                    Telephone = strTelephone,
                    Cellulaire = strCellulaire,
                    Courriel = strCourriel,
                    SalaireHoraire = dclMoney,
                    NoTypeEmploye = intTypeEmploye,
                    Remarque = strRemarque
                };
                try
                {
                    dataClasses1DataContext.Employes.InsertOnSubmit(empAjouter);
                    dataClasses1DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    dataClasses1DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'ajout des données");
                }
                this.Close();
            }

        }

        private void motDePasseTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool blnChiffre = false;
            bool blnLettre = false;
            bool blnAutre = false;
            string strMdeP = motDePasseTextBox.Text;
            if (strMdeP.Trim().Length < 8)
            {
                errMessage.SetError(motDePasseTextBox, "Le mot de passe est composé au minimum de 8 charactères");
                e.Cancel = true;
            }
            else
            {
                char[] lstChar = strMdeP.Trim().ToCharArray();
                foreach (char c in lstChar)
                {
                    if (Char.IsDigit(c))
                    {
                        blnChiffre = true;
                    }
                    else if (Char.IsLetter(c))
                    {
                        blnLettre = true;
                    }
                    else
                    {
                        blnAutre = true;
                    }
                }
                if(!blnChiffre || !blnLettre || !blnAutre)
                {
                    errMessage.SetError(motDePasseTextBox, "Le mot de passe doit contenir une lettre, un chiffre et un autre caractère");
                    e.Cancel = true;
                }
                else
                {
                    errMessage.SetError(motDePasseTextBox, "");
                }
            }
        }

        private void prenomTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strPrenom = prenomTextBox.Text;
            if (strPrenom.Trim().Length == 0)
            {
                errMessage.SetError(prenomTextBox, "Le prénom ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(prenomTextBox, "");
            }
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strNom = nomTextBox.Text;
            if (strNom.Trim().Length == 0)
            {
                errMessage.SetError(nomTextBox, "Le nom ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(nomTextBox, "");
            }
        }

        private void noCiviqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strNoCivique = noCiviqueTextBox.Text;
            if(strNoCivique.Trim().Length == 0)
            {
                errMessage.SetError(noCiviqueTextBox, "Le numéro civique ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(noCiviqueTextBox, "");
            }
        }

        private void rueTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strRue = rueTextBox.Text;
            if (strRue.Trim().Length == 0)
            {
                errMessage.SetError(rueTextBox, "La rue ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(rueTextBox, "");
            }
        }

        private void codePostalMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strCodePostal = codePostalMaskedTextBox.Text;
            if (strCodePostal.Trim().Length == 0 || !codePostalMaskedTextBox.MaskCompleted || !codePostalMaskedTextBox.MaskFull)
            {
                errMessage.SetError(codePostalMaskedTextBox, "Le code postal ne peut pas être vide ou manquer des charactères");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(codePostalMaskedTextBox, "");
            }
        }

        private void villeTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strVille = villeTextBox.Text;
            if (strVille.Trim().Length == 0)
            {
                errMessage.SetError(villeTextBox, "La ville ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(villeTextBox, "");
            }
        }

        private void telephoneMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strTelephone = telephoneMaskedTextBox.Text;
            if (strTelephone.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 10 || !telephoneMaskedTextBox.MaskFull || !telephoneMaskedTextBox.MaskCompleted)
            {
                errMessage.SetError(telephoneMaskedTextBox, "Le numéro de téléphone doit être composé de dix chiffres.");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(telephoneMaskedTextBox, "");
            }
        }

        private void courrielTextBox_Validating(object sender, CancelEventArgs e)
        {
            string strCourriel = courrielTextBox.Text;
            if (strCourriel.Trim().Length == 0)
            {
                errMessage.SetError(courrielTextBox, "Le courriel ne peut pas être vide");
                e.Cancel = true;
            }
            else
            {
                if (!strCourriel.Contains("@"))
                {
                    errMessage.SetError(courrielTextBox, "Le courriel doit contenir un '@'");
                    e.Cancel = true;
                }
                else
                {
                    string strCourrielPartDeux = strCourriel.Split('@')[1];
                    if (strCourrielPartDeux.Contains("@"))
                    {
                        errMessage.SetError(courrielTextBox, "Le courriel ne doit pas contenir deux '@'");
                        e.Cancel = true;
                    }
                    else if (strCourrielPartDeux.Contains("."))
                    {
                        string strCourrielPartTrois = strCourrielPartDeux.Split('.')[1];
                        if (strCourrielPartTrois.Contains("."))
                        {
                            errMessage.SetError(courrielTextBox, "Le courriel ne doit pas contenir deux domaines de premier niveau");
                            e.Cancel = true;
                        }
                        else
                        {
                            errMessage.SetError(courrielTextBox, "");
                        }
                    }
                    else
                    {
                        errMessage.SetError(courrielTextBox, "Le courriel doit contenir un domaine de premier niveau");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void noTypeEmployeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(noTypeEmployeComboBox.SelectedValue.ToString().Equals("1"))
            {
                errMessage.SetError(noTypeEmployeComboBox, "Vous ne pouvez pas ajouter un deuxième administrateur");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(noTypeEmployeComboBox, "");
            }
        }

        private void cellulaireMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            String strCell = cellulaireMaskedTextBox.Text;
            if (strCell.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length <10 && strCell.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 0)
            {
                if(!cellulaireMaskedTextBox.MaskCompleted && !cellulaireMaskedTextBox.MaskFull)
                { 
                    errMessage.SetError(cellulaireMaskedTextBox, "Le numéro de cellulaire doit être composé de dix chiffres.");
                    e.Cancel = true;
                }
            }
            else
            {
                errMessage.SetError(cellulaireMaskedTextBox, "");
            }
        }
    }
}
