namespace TP2
{
    partial class frmAbonnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label dateAbonnementLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noTypeAbonnementLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label dateNaissanceLabel1;
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label prenomLabel1;
            System.Windows.Forms.Label remarqueLabel1;
            System.Windows.Forms.Label sexeLabel1;
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.lblDateAbonnement = new System.Windows.Forms.Label();
            this.cmbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNaissanceDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nomTextBox1 = new System.Windows.Forms.TextBox();
            this.prenomTextBox1 = new System.Windows.Forms.TextBox();
            this.remarqueTextBox1 = new System.Windows.Forms.TextBox();
            this.btnConjoint = new System.Windows.Forms.Button();
            this.btnEnfant = new System.Windows.Forms.Button();
            this.lblAjoutePrincipal = new System.Windows.Forms.Label();
            this.lblConjointEnfant = new System.Windows.Forms.Label();
            this.btnEnregistrerAbonnement = new System.Windows.Forms.Button();
            this.btnConfirmerPrincipal = new System.Windows.Forms.Button();
            this.panelDependant = new System.Windows.Forms.Panel();
            this.lblEnfantsEnreg = new System.Windows.Forms.Label();
            this.lblNbEnfants = new System.Windows.Forms.Label();
            this.cmbSexeDependant = new System.Windows.Forms.ComboBox();
            this.cellulaireTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codePostalTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panelAbonnePrincipal = new System.Windows.Forms.Panel();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            dateAbonnementLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noTypeAbonnementLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel1 = new System.Windows.Forms.Label();
            nomLabel1 = new System.Windows.Forms.Label();
            prenomLabel1 = new System.Windows.Forms.Label();
            remarqueLabel1 = new System.Windows.Forms.Label();
            sexeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantBindingSource)).BeginInit();
            this.panelDependant.SuspendLayout();
            this.panelAbonnePrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(8, 168);
            cellulaireLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(52, 13);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(8, 142);
            codePostalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(66, 13);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(295, 169);
            courrielLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Location = new System.Drawing.Point(8, 17);
            dateAbonnementLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(96, 13);
            dateAbonnementLabel.TabIndex = 7;
            dateAbonnementLabel.Text = "Date Abonnement:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(295, 69);
            dateNaissanceLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(99, 13);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date de naissance:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(295, 117);
            idProvinceLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(8, 91);
            noCiviqueLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(8, 43);
            nomLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Location = new System.Drawing.Point(8, 198);
            noTypeAbonnementLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(104, 13);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "Type d\'abonnement:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(295, 44);
            prenomLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(43, 13);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(295, 196);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(295, 93);
            rueLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(8, 67);
            sexeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(295, 144);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Téléphone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(8, 116);
            villeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // dateNaissanceLabel1
            // 
            dateNaissanceLabel1.AutoSize = true;
            dateNaissanceLabel1.Location = new System.Drawing.Point(229, 27);
            dateNaissanceLabel1.Name = "dateNaissanceLabel1";
            dateNaissanceLabel1.Size = new System.Drawing.Size(99, 13);
            dateNaissanceLabel1.TabIndex = 35;
            dateNaissanceLabel1.Text = "Date de naissance:";
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(296, 57);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(32, 13);
            nomLabel1.TabIndex = 41;
            nomLabel1.Text = "Nom:";
            // 
            // prenomLabel1
            // 
            prenomLabel1.AutoSize = true;
            prenomLabel1.Location = new System.Drawing.Point(282, 83);
            prenomLabel1.Name = "prenomLabel1";
            prenomLabel1.Size = new System.Drawing.Size(46, 13);
            prenomLabel1.TabIndex = 43;
            prenomLabel1.Text = "Prénom:";
            // 
            // remarqueLabel1
            // 
            remarqueLabel1.AutoSize = true;
            remarqueLabel1.Location = new System.Drawing.Point(269, 136);
            remarqueLabel1.Name = "remarqueLabel1";
            remarqueLabel1.Size = new System.Drawing.Size(59, 13);
            remarqueLabel1.TabIndex = 45;
            remarqueLabel1.Text = "Remarque:";
            // 
            // sexeLabel1
            // 
            sexeLabel1.AutoSize = true;
            sexeLabel1.Location = new System.Drawing.Point(294, 110);
            sexeLabel1.Name = "sexeLabel1";
            sexeLabel1.Size = new System.Drawing.Size(34, 13);
            sexeLabel1.TabIndex = 47;
            sexeLabel1.Text = "Sexe:";
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(TP2.Abonnement);
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(409, 168);
            this.courrielTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(132, 20);
            this.courrielTextBox.TabIndex = 12;
            this.courrielTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.courrielTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.courrielTextBox_Validating);
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(409, 67);
            this.dateNaissanceDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 4;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(122, 90);
            this.noCiviqueTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.noCiviqueTextBox.MaxLength = 10;
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(132, 20);
            this.noCiviqueTextBox.TabIndex = 5;
            this.noCiviqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noCiviqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.noCiviqueTextBox_Validating);
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(122, 42);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.nomTextBox.MaxLength = 28;
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(132, 20);
            this.nomTextBox.TabIndex = 1;
            this.nomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox_Validating);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(409, 43);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.prenomTextBox.MaxLength = 30;
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(132, 20);
            this.prenomTextBox.TabIndex = 2;
            this.prenomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prenomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(409, 194);
            this.remarqueTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.remarqueTextBox.MaxLength = 50;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(132, 20);
            this.remarqueTextBox.TabIndex = 14;
            this.remarqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(409, 91);
            this.rueTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.rueTextBox.MaxLength = 30;
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(132, 20);
            this.rueTextBox.TabIndex = 6;
            this.rueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rueTextBox_Validating);
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(122, 114);
            this.villeTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.villeTextBox.MaxLength = 30;
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(132, 20);
            this.villeTextBox.TabIndex = 7;
            this.villeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.villeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.villeTextBox_Validating);
            // 
            // lblDateAbonnement
            // 
            this.lblDateAbonnement.AutoSize = true;
            this.lblDateAbonnement.Location = new System.Drawing.Point(122, 17);
            this.lblDateAbonnement.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDateAbonnement.Name = "lblDateAbonnement";
            this.lblDateAbonnement.Size = new System.Drawing.Size(0, 13);
            this.lblDateAbonnement.TabIndex = 33;
            // 
            // cmbTypeAbonnement
            // 
            this.cmbTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.cmbTypeAbonnement.DisplayMember = "Description";
            this.cmbTypeAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAbonnement.FormattingEnabled = true;
            this.cmbTypeAbonnement.Location = new System.Drawing.Point(122, 198);
            this.cmbTypeAbonnement.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTypeAbonnement.Name = "cmbTypeAbonnement";
            this.cmbTypeAbonnement.Size = new System.Drawing.Size(132, 21);
            this.cmbTypeAbonnement.TabIndex = 13;
            this.cmbTypeAbonnement.ValueMember = "No";
            this.cmbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cmbTypeAbonnement_SelectedIndexChanged);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(TP2.TypesAbonnement);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // cmbProvince
            // 
            this.cmbProvince.DataSource = this.provinceBindingSource;
            this.cmbProvince.DisplayMember = "Nom";
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(409, 117);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(132, 21);
            this.cmbProvince.TabIndex = 8;
            this.cmbProvince.ValueMember = "Id";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(TP2.Province);
            // 
            // cmbSexe
            // 
            this.cmbSexe.DataSource = this.sexeBindingSource;
            this.cmbSexe.DisplayMember = "Description";
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Location = new System.Drawing.Point(122, 66);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(132, 21);
            this.cmbSexe.TabIndex = 3;
            this.cmbSexe.ValueMember = "idSexe";
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(TP2.Sexe);
            // 
            // dependantBindingSource
            // 
            this.dependantBindingSource.DataSource = typeof(TP2.Dependant);
            // 
            // dateNaissanceDateTimePicker1
            // 
            this.dateNaissanceDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dependantBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker1.Enabled = false;
            this.dateNaissanceDateTimePicker1.Location = new System.Drawing.Point(334, 23);
            this.dateNaissanceDateTimePicker1.Name = "dateNaissanceDateTimePicker1";
            this.dateNaissanceDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateNaissanceDateTimePicker1.TabIndex = 16;
            // 
            // nomTextBox1
            // 
            this.nomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantBindingSource, "Nom", true));
            this.nomTextBox1.Enabled = false;
            this.nomTextBox1.Location = new System.Drawing.Point(334, 54);
            this.nomTextBox1.Name = "nomTextBox1";
            this.nomTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox1.TabIndex = 17;
            this.nomTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nomTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox1_Validating);
            // 
            // prenomTextBox1
            // 
            this.prenomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantBindingSource, "Prenom", true));
            this.prenomTextBox1.Enabled = false;
            this.prenomTextBox1.Location = new System.Drawing.Point(334, 80);
            this.prenomTextBox1.Name = "prenomTextBox1";
            this.prenomTextBox1.Size = new System.Drawing.Size(200, 20);
            this.prenomTextBox1.TabIndex = 18;
            this.prenomTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prenomTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox1_Validating);
            // 
            // remarqueTextBox1
            // 
            this.remarqueTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantBindingSource, "Remarque", true));
            this.remarqueTextBox1.Enabled = false;
            this.remarqueTextBox1.Location = new System.Drawing.Point(334, 133);
            this.remarqueTextBox1.MaxLength = 50;
            this.remarqueTextBox1.Name = "remarqueTextBox1";
            this.remarqueTextBox1.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox1.TabIndex = 20;
            this.remarqueTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConjoint
            // 
            this.btnConjoint.Location = new System.Drawing.Point(9, 27);
            this.btnConjoint.Name = "btnConjoint";
            this.btnConjoint.Size = new System.Drawing.Size(176, 23);
            this.btnConjoint.TabIndex = 21;
            this.btnConjoint.Text = "Ajouter un conjoint";
            this.btnConjoint.UseVisualStyleBackColor = true;
            this.btnConjoint.Click += new System.EventHandler(this.btnConjoint_Click);
            // 
            // btnEnfant
            // 
            this.btnEnfant.Location = new System.Drawing.Point(9, 83);
            this.btnEnfant.Name = "btnEnfant";
            this.btnEnfant.Size = new System.Drawing.Size(176, 23);
            this.btnEnfant.TabIndex = 22;
            this.btnEnfant.Text = "Ajouter un enfant";
            this.btnEnfant.UseVisualStyleBackColor = true;
            this.btnEnfant.Click += new System.EventHandler(this.btnEnfant_Click);
            // 
            // lblAjoutePrincipal
            // 
            this.lblAjoutePrincipal.AutoSize = true;
            this.lblAjoutePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutePrincipal.Location = new System.Drawing.Point(223, 22);
            this.lblAjoutePrincipal.Name = "lblAjoutePrincipal";
            this.lblAjoutePrincipal.Size = new System.Drawing.Size(261, 24);
            this.lblAjoutePrincipal.TabIndex = 51;
            this.lblAjoutePrincipal.Text = "Ajout de l\'abonné principal";
            // 
            // lblConjointEnfant
            // 
            this.lblConjointEnfant.AutoSize = true;
            this.lblConjointEnfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConjointEnfant.Location = new System.Drawing.Point(190, 319);
            this.lblConjointEnfant.Name = "lblConjointEnfant";
            this.lblConjointEnfant.Size = new System.Drawing.Size(325, 24);
            this.lblConjointEnfant.TabIndex = 52;
            this.lblConjointEnfant.Text = "Ajout d\'un conjoint ou d\'un enfant";
            // 
            // btnEnregistrerAbonnement
            // 
            this.btnEnregistrerAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerAbonnement.Location = new System.Drawing.Point(9, 167);
            this.btnEnregistrerAbonnement.Name = "btnEnregistrerAbonnement";
            this.btnEnregistrerAbonnement.Size = new System.Drawing.Size(176, 25);
            this.btnEnregistrerAbonnement.TabIndex = 23;
            this.btnEnregistrerAbonnement.Text = "Confirmer l\'ajout des enfants";
            this.btnEnregistrerAbonnement.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbonnement.Click += new System.EventHandler(this.btnEnregistrerAbonnement_Click);
            // 
            // btnConfirmerPrincipal
            // 
            this.btnConfirmerPrincipal.Location = new System.Drawing.Point(197, 234);
            this.btnConfirmerPrincipal.Name = "btnConfirmerPrincipal";
            this.btnConfirmerPrincipal.Size = new System.Drawing.Size(184, 23);
            this.btnConfirmerPrincipal.TabIndex = 15;
            this.btnConfirmerPrincipal.Text = "Confirmer l\'abonné principal";
            this.btnConfirmerPrincipal.UseVisualStyleBackColor = true;
            this.btnConfirmerPrincipal.Click += new System.EventHandler(this.btnConfirmerPrincipal_Click);
            // 
            // panelDependant
            // 
            this.panelDependant.Controls.Add(this.lblEnfantsEnreg);
            this.panelDependant.Controls.Add(this.btnEnregistrerAbonnement);
            this.panelDependant.Controls.Add(this.lblNbEnfants);
            this.panelDependant.Controls.Add(this.cmbSexeDependant);
            this.panelDependant.Controls.Add(sexeLabel1);
            this.panelDependant.Controls.Add(this.remarqueTextBox1);
            this.panelDependant.Controls.Add(this.btnEnfant);
            this.panelDependant.Controls.Add(remarqueLabel1);
            this.panelDependant.Controls.Add(this.btnConjoint);
            this.panelDependant.Controls.Add(this.prenomTextBox1);
            this.panelDependant.Controls.Add(dateNaissanceLabel1);
            this.panelDependant.Controls.Add(prenomLabel1);
            this.panelDependant.Controls.Add(this.dateNaissanceDateTimePicker1);
            this.panelDependant.Controls.Add(this.nomTextBox1);
            this.panelDependant.Controls.Add(nomLabel1);
            this.panelDependant.Location = new System.Drawing.Point(66, 346);
            this.panelDependant.Name = "panelDependant";
            this.panelDependant.Size = new System.Drawing.Size(567, 211);
            this.panelDependant.TabIndex = 55;
            // 
            // lblEnfantsEnreg
            // 
            this.lblEnfantsEnreg.AutoSize = true;
            this.lblEnfantsEnreg.Location = new System.Drawing.Point(12, 136);
            this.lblEnfantsEnreg.Name = "lblEnfantsEnreg";
            this.lblEnfantsEnreg.Size = new System.Drawing.Size(0, 13);
            this.lblEnfantsEnreg.TabIndex = 58;
            // 
            // lblNbEnfants
            // 
            this.lblNbEnfants.AutoSize = true;
            this.lblNbEnfants.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNbEnfants.Location = new System.Drawing.Point(12, 114);
            this.lblNbEnfants.Name = "lblNbEnfants";
            this.lblNbEnfants.Size = new System.Drawing.Size(0, 13);
            this.lblNbEnfants.TabIndex = 57;
            // 
            // cmbSexeDependant
            // 
            this.cmbSexeDependant.DataSource = this.sexeBindingSource;
            this.cmbSexeDependant.DisplayMember = "Description";
            this.cmbSexeDependant.Enabled = false;
            this.cmbSexeDependant.FormattingEnabled = true;
            this.cmbSexeDependant.Location = new System.Drawing.Point(334, 106);
            this.cmbSexeDependant.Name = "cmbSexeDependant";
            this.cmbSexeDependant.Size = new System.Drawing.Size(200, 21);
            this.cmbSexeDependant.TabIndex = 19;
            this.cmbSexeDependant.ValueMember = "idSexe";
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.Location = new System.Drawing.Point(122, 169);
            this.cellulaireTextBox.Mask = "(000) 000-0000";
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(132, 20);
            this.cellulaireTextBox.TabIndex = 11;
            this.cellulaireTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cellulaireTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cellulaireTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cellulaireTextBox_Validating);
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(409, 144);
            this.telephoneTextBox.Mask = "(000) 000-0000";
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(132, 20);
            this.telephoneTextBox.TabIndex = 10;
            this.telephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.telephoneTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.telephoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneTextBox_Validating);
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.Location = new System.Drawing.Point(122, 142);
            this.codePostalTextBox.Mask = "L0L-0L0";
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(132, 20);
            this.codePostalTextBox.TabIndex = 9;
            this.codePostalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.codePostalTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.codePostalTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codePostalTextBox_Validating);
            // 
            // panelAbonnePrincipal
            // 
            this.panelAbonnePrincipal.Controls.Add(this.courrielTextBox);
            this.panelAbonnePrincipal.Controls.Add(this.codePostalTextBox);
            this.panelAbonnePrincipal.Controls.Add(this.villeTextBox);
            this.panelAbonnePrincipal.Controls.Add(this.telephoneTextBox);
            this.panelAbonnePrincipal.Controls.Add(villeLabel);
            this.panelAbonnePrincipal.Controls.Add(this.cellulaireTextBox);
            this.panelAbonnePrincipal.Controls.Add(telephoneLabel);
            this.panelAbonnePrincipal.Controls.Add(sexeLabel);
            this.panelAbonnePrincipal.Controls.Add(this.btnConfirmerPrincipal);
            this.panelAbonnePrincipal.Controls.Add(this.rueTextBox);
            this.panelAbonnePrincipal.Controls.Add(rueLabel);
            this.panelAbonnePrincipal.Controls.Add(this.remarqueTextBox);
            this.panelAbonnePrincipal.Controls.Add(this.cmbSexe);
            this.panelAbonnePrincipal.Controls.Add(remarqueLabel);
            this.panelAbonnePrincipal.Controls.Add(this.cmbProvince);
            this.panelAbonnePrincipal.Controls.Add(this.prenomTextBox);
            this.panelAbonnePrincipal.Controls.Add(this.cmbTypeAbonnement);
            this.panelAbonnePrincipal.Controls.Add(prenomLabel);
            this.panelAbonnePrincipal.Controls.Add(this.lblDateAbonnement);
            this.panelAbonnePrincipal.Controls.Add(noTypeAbonnementLabel);
            this.panelAbonnePrincipal.Controls.Add(cellulaireLabel);
            this.panelAbonnePrincipal.Controls.Add(this.nomTextBox);
            this.panelAbonnePrincipal.Controls.Add(codePostalLabel);
            this.panelAbonnePrincipal.Controls.Add(nomLabel);
            this.panelAbonnePrincipal.Controls.Add(courrielLabel);
            this.panelAbonnePrincipal.Controls.Add(this.noCiviqueTextBox);
            this.panelAbonnePrincipal.Controls.Add(noCiviqueLabel);
            this.panelAbonnePrincipal.Controls.Add(dateAbonnementLabel);
            this.panelAbonnePrincipal.Controls.Add(idProvinceLabel);
            this.panelAbonnePrincipal.Controls.Add(dateNaissanceLabel);
            this.panelAbonnePrincipal.Controls.Add(this.dateNaissanceDateTimePicker);
            this.panelAbonnePrincipal.Location = new System.Drawing.Point(75, 51);
            this.panelAbonnePrincipal.Name = "panelAbonnePrincipal";
            this.panelAbonnePrincipal.Size = new System.Drawing.Size(552, 265);
            this.panelAbonnePrincipal.TabIndex = 59;
            // 
            // frmAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(713, 589);
            this.Controls.Add(this.panelAbonnePrincipal);
            this.Controls.Add(this.panelDependant);
            this.Controls.Add(this.lblConjointEnfant);
            this.Controls.Add(this.lblAjoutePrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAbonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.frmAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantBindingSource)).EndInit();
            this.panelDependant.ResumeLayout(false);
            this.panelDependant.PerformLayout();
            this.panelAbonnePrincipal.ResumeLayout(false);
            this.panelAbonnePrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.Label lblDateAbonnement;
        private System.Windows.Forms.ComboBox cmbTypeAbonnement;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.Label lblAjoutePrincipal;
        private System.Windows.Forms.Button btnEnfant;
        private System.Windows.Forms.Button btnConjoint;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker1;
        private System.Windows.Forms.BindingSource dependantBindingSource;
        private System.Windows.Forms.TextBox nomTextBox1;
        private System.Windows.Forms.TextBox prenomTextBox1;
        private System.Windows.Forms.TextBox remarqueTextBox1;
        private System.Windows.Forms.Label lblConjointEnfant;
        private System.Windows.Forms.Button btnConfirmerPrincipal;
        private System.Windows.Forms.Button btnEnregistrerAbonnement;
        private System.Windows.Forms.Panel panelDependant;
        private System.Windows.Forms.ComboBox cmbSexeDependant;
        private System.Windows.Forms.Label lblNbEnfants;
        private System.Windows.Forms.Label lblEnfantsEnreg;
        private System.Windows.Forms.MaskedTextBox cellulaireTextBox;
        private System.Windows.Forms.MaskedTextBox telephoneTextBox;
        private System.Windows.Forms.MaskedTextBox codePostalTextBox;
        private System.Windows.Forms.Panel panelAbonnePrincipal;
    }
}