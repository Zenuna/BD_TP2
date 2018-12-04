using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.Data.Linq;

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
        string strIDAbonnementPrincipal = "";
        List<Dependant> lstDependants = new List<Dependant>();
        public frmAbonnement(Employe empConnect)
        {
            InitializeComponent();
            empConnecter = empConnect;
        }

        private void frmAbonnement_Load(object sender, EventArgs e)
        {
            nbEnfantsAjoute = 0;
            booPrincipalAjoute = false;
            booConjointAjoute = false;
            booEnfantAjoute = false;
            strIDAbonnementPrincipal = "";
            lstDependants = new List<Dependant>();

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
                        Button btnPanel = ctrl as Button;
                        if(btnPanel != null)
                            btnPanel.Enabled = false;
                    }
                    lblNbEnfants.Text = "";
                    break;
                case 2:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-60);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        Button btnPanel = ctrl as Button;
                        if (btnPanel != null)
                            btnPanel.Enabled = false;
                    }
                    lblNbEnfants.Text = "";
                    break;
                case 3:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        Button btnPanel = ctrl as Button;
                        if (btnPanel != null)
                            btnPanel.Enabled = true;
                    }
                    lblNbEnfants.Text = "";
                    btnEnregistrerAbonnement.Enabled = false;
                    btnEnfant.Enabled = false;
                    break;
                case 4:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        Button btnPanel = ctrl as Button;
                        if (btnPanel != null)
                            btnPanel.Enabled = true;
                    }                    
                    lblNbEnfants.Text = "Nombre d'enfant minimum à enregistrer : 1";
                    break;
                case 5:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        Button btnPanel = ctrl as Button;
                        if (btnPanel != null)
                            btnPanel.Enabled = true;
                    }
                    lblNbEnfants.Text = "Nombre d'enfants minimum à enregistrer : 2";
                    break;
                case 6:
                    dateNaissanceDateTimePicker.MaxDate = DateTime.Now.Date.AddYears(-18);
                    foreach (Control ctrl in panelDependant.Controls)
                    {
                        Button btnPanel = ctrl as Button;
                        if (btnPanel != null)
                            btnPanel.Enabled = true;
                    }
                    lblNbEnfants.Text = "Nombre d'enfants minimum à enregistrer : 3";
                    break;                  
            }          
        }
       
        private void creationAbonnement(int idAjout, object sender, EventArgs e)
        {
            

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                              
                if (idAjout == 1)
                {
                    booPrincipalAjoute = true;
                    var tousLesAbonnements =
                        from abonnement in dataClasses1DataContext.Abonnements
                        select abonnement.Id;

                    int idAbonnement = tousLesAbonnements.Count() + 1;
                    string strIdAbonnement = "";
                    if (nomTextBox.Text.Length > 0)
                        strIdAbonnement = char.ToUpper(nomTextBox.Text[0]) + nomTextBox.Text.ToLower().Substring(1) + idAbonnement;
                    string strProvince = cmbProvince.SelectedValue.ToString();
                    strIDAbonnementPrincipal = strIdAbonnement + "P";
                    DateTime dateAbonnement = Convert.ToDateTime(lblDateAbonnement.Text);

                    var nouvelAbonnerPrincipal = new Abonnement
                    {
                        Id = strIDAbonnementPrincipal,
                        DateAbonnement = dateAbonnement,
                        Nom = nomTextBox.Text,
                        Prenom= prenomTextBox.Text,
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
                        dataClasses1DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                        MessageBox.Show($"L'abonnennement {strIdAbonnement} a été ajouté", "Enregistrement de l'abonné principal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (Control ctrl in panelAbonnePrincipal.Controls)
                        {
                            TextBox txtboxAbonnement = ctrl as TextBox;
                            if (txtboxAbonnement != null)
                            {
                                txtboxAbonnement.ReadOnly = true;                              
                            }
                            MaskedTextBox maskedtxtBox = ctrl as MaskedTextBox;
                            if (maskedtxtBox != null) maskedtxtBox.ReadOnly = true;
                            Button btnAjoute = ctrl as Button;
                            if (btnAjoute != null) btnAjoute.Enabled = false;
                            ComboBox combo = ctrl as ComboBox;
                            if (combo != null)
                            {                                
                                combo.Enabled = false;
                            }
                        }
                        dateNaissanceDateTimePicker.Enabled = false;
                        // Devrait juste enable selon le combo ?
                        // Parce que sinon ça enable dès le clique
                        foreach (Control ctrl in panelDependant.Controls)
                        {
                            ctrl.Enabled = true;
                        }
                        cmbTypeAbonnement_SelectedIndexChanged(this, new EventArgs());
                        if (Convert.ToInt32(cmbTypeAbonnement.SelectedValue) == 1 || Convert.ToInt32(cmbTypeAbonnement.SelectedValue) == 2)
                        {
                            resetForm(sender, e);
                            btnEnregistrerAbonnement.Enabled = false;
                        }
                    }
                    catch (ChangeConflictException)
                    {
                        dataClasses1DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("L'abonnennement a échoué "+ex, "Enregistrement de l'abonné principal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }else if(idAjout == 2)
                {
                    if (!booPrincipalAjoute)
                    {
                        MessageBox.Show("L'abonné principal n'a pas été ajouté", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dateNaissanceDateTimePicker1.Value > DateTime.Now.Date.AddYears(-18))
                    {
                        MessageBox.Show("Le/La conjoint(e) doit avoir plus de 18 ans", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string strIDConjoint = strIDAbonnementPrincipal.Substring(0, strIDAbonnementPrincipal.Length - 1) + cmbSexe.SelectedValue + "0";                        
                        var nouveauDependant = new Dependant
                        {
                            Id = strIDConjoint,
                            Nom = nomTextBox1.Text,
                            Prenom = prenomTextBox1.Text,
                            Sexe = Convert.ToChar(cmbSexeDependant.SelectedValue),
                            DateNaissance = Convert.ToDateTime(dateNaissanceDateTimePicker1.Value),
                            IdAbonnement = strIDAbonnementPrincipal,
                            Remarque = remarqueTextBox1.Text
                        };

                        dataClasses1DataContext.Dependants.InsertOnSubmit(nouveauDependant);

                        try
                        {
                            dataClasses1DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                            MessageBox.Show($"Le dépendant (Conjoint) {strIDConjoint} a été ajouté", "Enregistrement du conjoint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnConjoint.Enabled = false;
                            booConjointAjoute = true;
                            if(Convert.ToInt32(cmbTypeAbonnement.SelectedValue) == 3)
                            {
                                resetForm(sender, e);
                                btnEnregistrerAbonnement.Enabled = false;
                            }
                        }
                        catch (ChangeConflictException)
                        {
                            dataClasses1DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("L'ajout du dépendant a échoué", "Enregistrement du conjoint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    
                }else if(idAjout == 3)
                {
                    if (!booPrincipalAjoute)
                    {
                        MessageBox.Show("L'abonné principal n'a pas été ajouté", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!booConjointAjoute)
                    {
                        MessageBox.Show("Le/La conjoint(e) n'a pas été ajouté(e)", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dateNaissanceDateTimePicker1.Value <= DateTime.Now.Date.AddYears(-18) || dateNaissanceDateTimePicker1.Value >= DateTime.Now.Date)
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
                            btnEnfant.Enabled = false;
                        }
                        else if ((nbEnfantsAjoute <= intNbEnfants) || intNbEnfants == 3)
                        {                      
                               
                            if(intNbEnfants != 3 && nbEnfantsAjoute == intNbEnfants)
                            {
                                btnEnfant.Enabled = false;
                                booEnfantAjoute = true;
                                MessageBox.Show("Vous avez enregistré le nombre maximal d'enfant pour ce type d'abonnement \n\nVeuillez confirmer l'ajout des enfants.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {                                
                                nbEnfantsAjoute++;
                                if (intNbEnfants == 3 && intNbEnfants == nbEnfantsAjoute) booEnfantAjoute = true;
                                string strIDEnfant = strIDAbonnementPrincipal.Substring(0, strIDAbonnementPrincipal.Length - 1) + "E" + nbEnfantsAjoute;                              
                                var nouveauDependant = new Dependant
                                {
                                    Id = strIDEnfant,
                                    Nom = nomTextBox1.Text,
                                    Prenom = prenomTextBox1.Text,
                                    Sexe = Convert.ToChar(cmbSexeDependant.SelectedValue),
                                    DateNaissance = Convert.ToDateTime(dateNaissanceDateTimePicker1.Value),
                                    IdAbonnement = strIDAbonnementPrincipal,
                                    Remarque = remarqueTextBox1.Text
                                };
                                lstDependants.Add(nouveauDependant);                           
                                lblEnfantsEnreg.Text = nbEnfantsAjoute + " enfant(s) ajouté(s)";
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
               errMessage.SetError(nomTextBox, "Le nom ne peut pas être vide");
               e.Cancel = true;
            }else if(!Regex.IsMatch(nomTextBox.Text, "^[a-zA-Z]+$") || nomTextBox.Text.Length > 28)
            {
                errMessage.SetError(nomTextBox, "Le nom doit contenir seulement des lettres et une longueur maximale de 28 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(nomTextBox, "");
        }


        private void noCiviqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (noCiviqueTextBox.Text.ToString().Trim().Equals(""))
            {
                errMessage.SetError(noCiviqueTextBox, "Le numéro civique ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(noCiviqueTextBox.Text, @"^\d+[A-Z]?$") || noCiviqueTextBox.Text.Length > 10)
            {
                errMessage.SetError(noCiviqueTextBox, "Le format n'est pas valide ou la longueur dépasse 10 caractères\n\n Format valide : 999 , 999A , 999B . (Lettre majuscule seulement)");
                e.Cancel = true;
            }
            else errMessage.SetError(noCiviqueTextBox, "");
        }

        private void villeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (villeTextBox.Text.ToString().Trim().Equals(""))
            {
                errMessage.SetError(villeTextBox, "Le numéro civique ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(villeTextBox.Text, "^[a-zA-Z]+$") || villeTextBox.Text.Length > 30)
            {
                errMessage.SetError(villeTextBox, "Le nom de la ville doit contenir seulement des lettres et une longueur maximale de 30 caractères");
                e.Cancel = true;
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
                errMessage.SetError(prenomTextBox, "Le prénom ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(prenomTextBox.Text, "^[a-zA-Z]+$") || prenomTextBox.Text.Length > 30)
            {
                errMessage.SetError(prenomTextBox, "Le prénom doit contenir seulement des lettres et une longueur maximale de 28 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(prenomTextBox, "");
        }

        private void rueTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (rueTextBox.Text.ToString().Trim().Equals(""))
            {
                errMessage.SetError(rueTextBox, "Le nom de la rue ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(rueTextBox.Text, "^[a-zA-Z0-9]+$") || rueTextBox.Text.Length > 30)
            {
                errMessage.SetError(rueTextBox, "Le nom de la rue doit contenir seulement des lettres et une longueur maximale de 30 caractères");
                e.Cancel = true;
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
            Regex regex = new Regex(@"^(([A-Za-zÀ-ÿ0-9])+[\w\.\-]?)+@([\w\-]+)((\.([A-Za-zÀ-ÿ]){2,3})+)$");
           
            if (!regex.IsMatch(courrielTextBox.Text))
            {
                errMessage.SetError(courrielTextBox, "Le courriel n'a pas un format valide\n\nExemple : email@cgodin.ca\n\n Seul les caractères spéciaux ( _ , . , -) sont permis");
                e.Cancel = true;
            }
            else errMessage.SetError(courrielTextBox, "");
        }

        private void btnConfirmerPrincipal_Click(object sender, EventArgs e)
        {
            creationAbonnement(1,sender,e);
        }

        private void btnConjoint_Click(object sender, EventArgs e)
        {
            creationAbonnement(2, sender, e);
        }

        private void btnEnfant_Click(object sender, EventArgs e)
        {
            creationAbonnement(3, sender, e);
        }

        private void nomTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (nomTextBox1.Text.ToString().Trim().Equals(""))
            {
                errMessage.SetError(nomTextBox1, "Le numéro de téléphone ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(nomTextBox1.Text, "^[a-zA-Z]+$") || nomTextBox1.Text.Length > 30)
            {
                errMessage.SetError(nomTextBox1, "Le nom de la personne doit contenir seulement des lettres et une longueur maximale de 30 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(nomTextBox1, "");
        }

        private void prenomTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (prenomTextBox1.Text.ToString().Trim().Equals(""))
            {
                errMessage.SetError(prenomTextBox1, "Le numéro de téléphone ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(prenomTextBox1.Text, "^[a-zA-Z]+$") || prenomTextBox1.Text.Length > 30)
            {
                errMessage.SetError(prenomTextBox1, "Le prénom de la personne doit contenir seulement des lettres et une longueur maximale de 30 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(prenomTextBox1, "");
        }

        private void cellulaireTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!cellulaireTextBox.Text.Equals("") && !cellulaireTextBox.MaskCompleted)
            {
                errMessage.SetError(cellulaireTextBox, "Le numéro de cellulaire doit respecter le format (999) 999-9999");
                e.Cancel = true;
            }
            else errMessage.SetError(cellulaireTextBox, "");
        }

        private void btnEnregistrerAbonnement_Click(object sender, EventArgs e)
        {
            if (booEnfantAjoute)
            {
                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        lstDependants.ForEach(c => dataClasses1DataContext.Dependants.InsertOnSubmit(c));
                        dataClasses1DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                        MessageBox.Show($"Le(s) dépendant(s) (enfant) a/ont été(s) ajouté(s)", "Enregistrement de dépendants", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        porteeTransaction.Complete();
                        resetForm(sender,e);
                        btnEnregistrerAbonnement.Enabled = false;
                    }
                    catch (ChangeConflictException)
                    {
                        dataClasses1DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("L'ajout de l'enfant a échoué", "Enregistrement de dépendants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }else
            {
                 MessageBox.Show("Aucun enfant a été ajouté", "Enregistrement de dépendants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void resetForm(object sender, EventArgs e)
        {
            foreach(Control ctrl in panelAbonnePrincipal.Controls)
            {
                TextBox txtbox = ctrl as TextBox;
                if (txtbox != null)
                {
                    txtbox.Text = "";
                    txtbox.ReadOnly = false;
                }               
                ComboBox combo = ctrl as ComboBox;
                if (combo != null)
                {
                    combo.SelectedIndex = 0;
                    combo.Enabled = true;
                }                
                MaskedTextBox maskedText = ctrl as MaskedTextBox;
                if (maskedText != null)
                {
                    maskedText.Text = "";
                    maskedText.ReadOnly = false;
                }                
            }
            foreach (Control ctrl in panelDependant.Controls)
            {
                TextBox txtbox = ctrl as TextBox;
                if (txtbox != null)
                {
                    txtbox.Text = "";
                    txtbox.Enabled = false;
                }
            }
            cmbSexeDependant.Enabled = false;
            dateNaissanceDateTimePicker.Enabled = true;
            dateNaissanceDateTimePicker1.Enabled = false;
            btnConfirmerPrincipal.Enabled = true;
            lblEnfantsEnreg.Text = "";
            lblNbEnfants.Text = "";
            frmAbonnement_Load(sender, e);
        }
    }
}
