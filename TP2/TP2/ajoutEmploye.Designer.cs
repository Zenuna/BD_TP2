﻿namespace TP2
{
    partial class ajoutEmploye
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
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noTypeEmployeLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label salaireHoraireLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellulaireMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.motDePasseTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.idProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexeComboBox = new System.Windows.Forms.ComboBox();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.noTypeEmployeComboBox = new System.Windows.Forms.ComboBox();
            this.salaireHoraireNumericUpDown = new TP2.NumericUpDownEx();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            ageLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noTypeEmployeLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            salaireHoraireLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaireHoraireNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(108, 135);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(43, 19);
            ageLabel.TabIndex = 1;
            ageLabel.Text = "Âge:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellulaireLabel.Location = new System.Drawing.Point(71, 310);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(80, 19);
            cellulaireLabel.TabIndex = 3;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(53, 210);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(98, 19);
            codePostalLabel.TabIndex = 5;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courrielLabel.Location = new System.Drawing.Point(80, 335);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(71, 19);
            courrielLabel.TabIndex = 7;
            courrielLabel.Text = "Courriel:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProvinceLabel.Location = new System.Drawing.Point(76, 260);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(75, 19);
            idProvinceLabel.TabIndex = 9;
            idProvinceLabel.Text = "Province:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motDePasseLabel.Location = new System.Drawing.Point(44, 35);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(107, 19);
            motDePasseLabel.TabIndex = 11;
            motDePasseLabel.Text = "Mot de passe:";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noLabel.Location = new System.Drawing.Point(116, 10);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(35, 19);
            noLabel.TabIndex = 13;
            noLabel.Text = "No:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noCiviqueLabel.Location = new System.Drawing.Point(25, 160);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(126, 19);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "Numéro civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(102, 85);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(49, 19);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeEmployeLabel.Location = new System.Drawing.Point(24, 384);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(127, 19);
            noTypeEmployeLabel.TabIndex = 19;
            noTypeEmployeLabel.Text = "Type d\'employé:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(81, 60);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(70, 19);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(64, 410);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(87, 19);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rueLabel.Location = new System.Drawing.Point(109, 185);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(42, 19);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaireHoraireLabel.Location = new System.Drawing.Point(32, 360);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(117, 19);
            salaireHoraireLabel.TabIndex = 27;
            salaireHoraireLabel.Text = "Salaire horaire:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexeLabel.Location = new System.Drawing.Point(103, 110);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(48, 19);
            sexeLabel.TabIndex = 29;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(62, 285);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(89, 19);
            telephoneLabel.TabIndex = 31;
            telephoneLabel.Text = "Téléphone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(106, 235);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(45, 19);
            villeLabel.TabIndex = 33;
            villeLabel.Text = "Ville:";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeBindingSource, "Age", true));
            this.ageNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageNumericUpDown.Location = new System.Drawing.Point(156, 135);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(254, 21);
            this.ageNumericUpDown.TabIndex = 2;
            this.ageNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataSource = typeof(TP2.Employe);
            // 
            // cellulaireMaskedTextBox
            // 
            this.cellulaireMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Cellulaire", true));
            this.cellulaireMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellulaireMaskedTextBox.Location = new System.Drawing.Point(156, 311);
            this.cellulaireMaskedTextBox.Mask = "(000) 000-0000";
            this.cellulaireMaskedTextBox.Name = "cellulaireMaskedTextBox";
            this.cellulaireMaskedTextBox.Size = new System.Drawing.Size(254, 21);
            this.cellulaireMaskedTextBox.TabIndex = 4;
            this.cellulaireMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cellulaireMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cellulaireMaskedTextBox_Validating);
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "CodePostal", true));
            this.codePostalMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(156, 210);
            this.codePostalMaskedTextBox.Mask = "L0L 0L0";
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(254, 21);
            this.codePostalMaskedTextBox.TabIndex = 6;
            this.codePostalMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.codePostalMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codePostalMaskedTextBox_Validating);
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "MotDePasse", true));
            this.motDePasseTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasseTextBox.Location = new System.Drawing.Point(156, 34);
            this.motDePasseTextBox.MaxLength = 50;
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(254, 21);
            this.motDePasseTextBox.TabIndex = 12;
            this.motDePasseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.motDePasseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.motDePasseTextBox_Validating);
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "No", true));
            this.noTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTextBox.Location = new System.Drawing.Point(156, 9);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.ReadOnly = true;
            this.noTextBox.Size = new System.Drawing.Size(254, 21);
            this.noTextBox.TabIndex = 14;
            this.noTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(156, 160);
            this.noCiviqueTextBox.MaxLength = 10;
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(254, 21);
            this.noCiviqueTextBox.TabIndex = 16;
            this.noCiviqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noCiviqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.noCiviqueTextBox_Validating);
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Nom", true));
            this.nomTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(156, 84);
            this.nomTextBox.MaxLength = 50;
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(254, 21);
            this.nomTextBox.TabIndex = 18;
            this.nomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox_Validating);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Prenom", true));
            this.prenomTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTextBox.Location = new System.Drawing.Point(156, 59);
            this.prenomTextBox.MaxLength = 50;
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(254, 21);
            this.prenomTextBox.TabIndex = 22;
            this.prenomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prenomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Remarque", true));
            this.remarqueTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(156, 412);
            this.remarqueTextBox.MaxLength = 50;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(254, 21);
            this.remarqueTextBox.TabIndex = 24;
            this.remarqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Rue", true));
            this.rueTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rueTextBox.Location = new System.Drawing.Point(156, 185);
            this.rueTextBox.MaxLength = 50;
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(254, 21);
            this.rueTextBox.TabIndex = 26;
            this.rueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rueTextBox_Validating);
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Ville", true));
            this.villeTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeTextBox.Location = new System.Drawing.Point(156, 235);
            this.villeTextBox.MaxLength = 50;
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(254, 21);
            this.villeTextBox.TabIndex = 34;
            this.villeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.villeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.villeTextBox_Validating);
            // 
            // idProvinceComboBox
            // 
            this.idProvinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "IdProvince", true));
            this.idProvinceComboBox.DataSource = this.provinceBindingSource;
            this.idProvinceComboBox.DisplayMember = "Nom";
            this.idProvinceComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProvinceComboBox.FormattingEnabled = true;
            this.idProvinceComboBox.Location = new System.Drawing.Point(156, 260);
            this.idProvinceComboBox.Name = "idProvinceComboBox";
            this.idProvinceComboBox.Size = new System.Drawing.Size(254, 21);
            this.idProvinceComboBox.TabIndex = 35;
            this.idProvinceComboBox.ValueMember = "Id";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(TP2.Province);
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(TP2.TypesEmploye);
            // 
            // sexeComboBox
            // 
            this.sexeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Sexe", true));
            this.sexeComboBox.DataSource = this.sexeBindingSource;
            this.sexeComboBox.DisplayMember = "Description";
            this.sexeComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexeComboBox.FormattingEnabled = true;
            this.sexeComboBox.Location = new System.Drawing.Point(156, 109);
            this.sexeComboBox.Name = "sexeComboBox";
            this.sexeComboBox.Size = new System.Drawing.Size(254, 21);
            this.sexeComboBox.TabIndex = 37;
            this.sexeComboBox.ValueMember = "idSexe";
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(TP2.Sexe);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(214, 452);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(173, 41);
            this.btnRetour.TabIndex = 39;
            this.btnRetour.Text = "Retour aux employés";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(35, 452);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(173, 41);
            this.btnAjouter.TabIndex = 38;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // noTypeEmployeComboBox
            // 
            this.noTypeEmployeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "NoTypeEmploye", true));
            this.noTypeEmployeComboBox.DataSource = this.typesEmployeBindingSource;
            this.noTypeEmployeComboBox.DisplayMember = "Description";
            this.noTypeEmployeComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTypeEmployeComboBox.FormattingEnabled = true;
            this.noTypeEmployeComboBox.Location = new System.Drawing.Point(156, 386);
            this.noTypeEmployeComboBox.Name = "noTypeEmployeComboBox";
            this.noTypeEmployeComboBox.Size = new System.Drawing.Size(254, 21);
            this.noTypeEmployeComboBox.TabIndex = 36;
            this.noTypeEmployeComboBox.ValueMember = "No";
            this.noTypeEmployeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.noTypeEmployeComboBox_Validating);
            // 
            // salaireHoraireNumericUpDown
            // 
            this.salaireHoraireNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeBindingSource, "SalaireHoraire", true));
            this.salaireHoraireNumericUpDown.DecimalPlaces = 2;
            this.salaireHoraireNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaireHoraireNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.salaireHoraireNumericUpDown.Location = new System.Drawing.Point(155, 361);
            this.salaireHoraireNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaireHoraireNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.salaireHoraireNumericUpDown.Name = "salaireHoraireNumericUpDown";
            this.salaireHoraireNumericUpDown.Size = new System.Drawing.Size(257, 21);
            this.salaireHoraireNumericUpDown.TabIndex = 40;
            this.salaireHoraireNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salaireHoraireNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.salaireHoraireNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Telephone", true));
            this.telephoneMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(155, 287);
            this.telephoneMaskedTextBox.Mask = "(000) 000-0000";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(255, 21);
            this.telephoneMaskedTextBox.TabIndex = 41;
            this.telephoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.telephoneMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneMaskedTextBox_Validating);
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "Courriel", true));
            this.courrielTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courrielTextBox.Location = new System.Drawing.Point(155, 337);
            this.courrielTextBox.MaxLength = 50;
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(255, 21);
            this.courrielTextBox.TabIndex = 42;
            this.courrielTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.courrielTextBox_Validating);
            // 
            // ajoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 525);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(this.telephoneMaskedTextBox);
            this.Controls.Add(this.salaireHoraireNumericUpDown);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.sexeComboBox);
            this.Controls.Add(this.noTypeEmployeComboBox);
            this.Controls.Add(this.idProvinceComboBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.cellulaireMaskedTextBox);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalMaskedTextBox);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.motDePasseTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ajoutEmploye";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un employé";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaireHoraireNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeBindingSource;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.MaskedTextBox cellulaireMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox codePostalMaskedTextBox;
        private System.Windows.Forms.TextBox motDePasseTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.ComboBox idProvinceComboBox;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.ComboBox sexeComboBox;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.ComboBox noTypeEmployeComboBox;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private NumericUpDownEx salaireHoraireNumericUpDown;
    }
}