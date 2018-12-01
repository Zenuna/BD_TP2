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
    public partial class frmAbonnement : Form

    {
        DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
        Employe empConnecter;
        int nbEnfantsAjoute = 0;
        bool booPrincipalAjoute = false;
        bool booConjointAjoute = false;
        bool booEnfantAjoute = false;
        public frmAbonnement(Employe empConnect)
        {
            InitializeComponent();
            empConnecter = empConnect;
        }

        private void frmAbonnement_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = dataClasses1DataContext.TypesAbonnements;
            provinceBindingSource.DataSource = dataClasses1DataContext.Provinces;
            sexeBindingSource.DataSource = dataClasses1DataContext.Sexes;

            dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
            dateNaissanceDateTimePicker1.MaxDate = DateTime.Now.Date;
            lblDateAbonnement.Text = DateTime.Now.Date.ToShortDateString();
            cmbTypeAbonnement_SelectedIndexChanged(sender, e);           
        }

        private void cmbTypeAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Int32.Parse(cmbTypeAbonnement.SelectedValue.ToString()))
            {
                case 1:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        ctrl.Enabled = false;
                    }
                    break;
                case 2:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-60);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        ctrl.Enabled = false;
                    }
                    break;
                case 3:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        ctrl.Enabled = true;
                    }
                    btnEnfant.Enabled = false;
                    break;
                case 4:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        ctrl.Enabled = true;
                    }                    
                    lblNbEnfants.Text = "Nombre d'enfants minimum à enregistrer : 1";
                    break;
                case 5:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        ctrl.Enabled = true;
                    }
                    lblNbEnfants.Text = "Nombre d'enfants minimum à enregistrer : 2";
                    break;
                case 6:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        ctrl.Enabled = true;
                    }
                    lblNbEnfants.Text = "Nombre d'enfants minimum à enregistrer : 3";
                    break;                  
            }          
        }
        private void creationAbonnement(int idAjout)
        {
            

            if (this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                if (idAjout == 1)
                {
                    booPrincipalAjoute = true;
                    var tousLesAbonnements =
                        from abonnement in dataClasses1DataContext.Abonnements
                        select abonnement.Id;

                    int idAbonnement = tousLesAbonnements.Count() + 1;

                    string strIdAbonnement="";
                    if (nomTextBox.Text.Length > 0)
                        strIdAbonnement = char.ToUpper(nomTextBox.Text[0]) + nomTextBox.Text.ToLower().Substring(1) + "P";

                    string strProvince = cmbProvince.SelectedValue.ToString();
                    DateTime dateAbonnement = Convert.ToDateTime(lblDateAbonnement.Text);

                    var nouvelAbonnerPrincipal = new Abonnement
                    {
                        Id = strIdAbonnement,
                        DateAbonnement = dateAbonnement,
                        Nom = nomTextBox.Text,
                        Prenom = prenomTextBox.Text,
                        Sexe = Convert.ToChar(cmbSexe.SelectedValue),
                        DateNaissance = Convert.ToDateTime(dateNaissanceDateTimePicker.Value),
                        NoCivique = noCiviqueTextBox.Text,
                        Rue = rueTextBox.Text,
                        Ville = villeTextBox.Text,
                        IdProvince = cmbProvince.SelectedValue.ToString(),
                        CodePostal = codePostalTextBox.Text,
                        Telephone = telephoneTextBox.Text,
                        Cellulaire = cellulaireTextBox.Text,
                        Courriel = courrielTextBox.Text, 
                        NoTypeAbonnement = Convert.ToInt32(cmbTypeAbonnement.SelectedValue),
                        Remarque = remarqueTextBox.Text                       

                    };

                    dataClasses1DataContext.Abonnements.InsertOnSubmit(nouvelAbonnerPrincipal);

                    try
                    {
                        dataClasses1DataContext.SubmitChanges();
                        MessageBox.Show($"L'abonnennement {strIdAbonnement} a été ajouté", "Enregistrement de l'abonné principal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("L'abonnennement a échoué"+ex, "Enregistrement de l'abonné principal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }else if(idAjout == 2)
                {
                    if (!booPrincipalAjoute)
                    {
                        MessageBox.Show("L'abonné principal n'a pas été ajouté", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dateNaissanceDateTimePicker1.Value > DateTime.Now.Date.AddYears(-18))
                    {
                        MessageBox.Show("Le conjoint dois avoir plus de 18 ans", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        booConjointAjoute = true;
                    }
                    
                }else if(idAjout == 3)
                {
                    if (!booPrincipalAjoute)
                    {
                        MessageBox.Show("L'abonné principal n'a pas été ajouté", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!booConjointAjoute)
                    {
                        MessageBox.Show("Le conjoint n'a pas été ajouté", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dateNaissanceDateTimePicker1.Value < DateTime.Now.Date.AddYears(-18) || dateNaissanceDateTimePicker1.Value >= DateTime.Now.Date)
                    {
                        MessageBox.Show("L'enfant doit avoir entre 0 et 18 ans", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int intNbEnfants = 0;
                        switch (Int32.Parse(cmbTypeAbonnement.SelectedValue.ToString()))
                        {
                            case 4:
                                intNbEnfants = 1;
                                break;
                            case 5:
                                intNbEnfants = 2;
                                break;
                            case 6:
                                intNbEnfants = 3;
                                break;
                        }
                        if (nbEnfantsAjoute == 9)
                        {
                            MessageBox.Show("Vous ne pouvez pas ajouter plus de 9 enfants", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if ((nbEnfantsAjoute < intNbEnfants) || intNbEnfants == 3)
                        {
                            booEnfantAjoute = true;
                            nbEnfantsAjoute++;
                            lblEnfantsEnreg.Text = nbEnfantsAjoute + " enfant(s) ajouté(s)";      
                            if(intNbEnfants != 3 && nbEnfantsAjoute == intNbEnfants)
                            {
                                MessageBox.Show("Vous avez enregistré le nombre d'enfant maximal pour le type d'abonnement \n\nVeuillez confirmé l'ajout des enfants.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }                    
                    }
            

                }
                
             
            }
            
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nomTextBox.Text.ToString().Trim().Equals(""))
            {
               // errMessage.SetError(nomTextBox, "Le nom ne peut pas être vide");
              //  e.Cancel = true;
            }
            else errMessage.SetError(nomTextBox, "");
        }


        private void noCiviqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (noCiviqueTextBox.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(noCiviqueTextBox, "Le numéro civique ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(noCiviqueTextBox, "");
        }

        private void villeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (villeTextBox.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(villeTextBox, "Le numéro civique ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(villeTextBox, "");

        }

        private void codePostalTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!codePostalTextBox.MaskCompleted || !codePostalTextBox.MaskFull)
            {
                errMessage.SetError(codePostalTextBox, "Le code postal doit respecter le format (L0L-0L0)");
                e.Cancel = true;
            }
            else errMessage.SetError(codePostalTextBox, "");
        }

        private void prenomTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (prenomTextBox.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(prenomTextBox, "Le prenom ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(prenomTextBox, "");
        }

        private void rueTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (rueTextBox.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(rueTextBox, "Le nom de la rue ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(rueTextBox, "");
        }

        private void telephoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!telephoneTextBox.MaskCompleted)
            {
                 errMessage.SetError(telephoneTextBox, "Le numéro de téléphone doit respecter le format (999) 999-9999");
                  e.Cancel = true;
            }
            else errMessage.SetError(telephoneTextBox, "");
        }

        private void courrielTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (courrielTextBox.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(courrielTextBox, "Le numéro de téléphone ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(courrielTextBox, "");
        }

        private void btnConfirmerPrincipal_Click(object sender, EventArgs e)
        {
            creationAbonnement(1);
        }

        private void btnConjoint_Click(object sender, EventArgs e)
        {
            creationAbonnement(2);
        }

        private void btnEnfant_Click(object sender, EventArgs e)
        {
            creationAbonnement(3);
        }

        private void nomTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (nomTextBox1.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(nomTextBox1, "Le numéro de téléphone ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(nomTextBox1, "");
        }

        private void prenomTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (prenomTextBox1.Text.ToString().Trim().Equals(""))
            {
                // errMessage.SetError(prenomTextBox1, "Le numéro de téléphone ne peut pas être vide");
                //  e.Cancel = true;
            }
            else errMessage.SetError(prenomTextBox1, "");
        }

        private void cellulaireTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!cellulaireTextBox.MaskCompleted)
            {
                errMessage.SetError(cellulaireTextBox, "Le numéro de cellulaire doit respecter le format (999) 999-9999");
                e.Cancel = true;
            }
            else errMessage.SetError(cellulaireTextBox, "");
        }
    }
}
