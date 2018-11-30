namespace TP2
{
    partial class frmAbonnement1
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
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellulaireTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idProvinceTextBox = new System.Windows.Forms.TextBox();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.sexeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.lblDateAbonnement = new System.Windows.Forms.Label();
            this.cmbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(139, 415);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(144, 32);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(139, 354);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(178, 32);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(904, 418);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(123, 32);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Location = new System.Drawing.Point(139, 54);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(252, 32);
            dateAbonnementLabel.TabIndex = 7;
            dateAbonnementLabel.Text = "Date Abonnement:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(904, 178);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(223, 32);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(904, 293);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(134, 32);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(139, 232);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(162, 32);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(139, 117);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(82, 32);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Location = new System.Drawing.Point(139, 487);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(298, 32);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "No Type Abonnement:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(904, 120);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(122, 32);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prenom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(904, 481);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(155, 32);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(904, 235);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(75, 32);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(139, 174);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(88, 32);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(904, 357);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(159, 32);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Telephone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(139, 290);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(79, 32);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(TP2.Abonnement);
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Cellulaire", true));
            this.cellulaireTextBox.Location = new System.Drawing.Point(443, 412);
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(289, 38);
            this.cellulaireTextBox.TabIndex = 2;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(443, 351);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(289, 38);
            this.codePostalTextBox.TabIndex = 4;
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(1208, 415);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(331, 38);
            this.courrielTextBox.TabIndex = 6;
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(1208, 174);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(331, 38);
            this.dateNaissanceDateTimePicker.TabIndex = 10;
            // 
            // idProvinceTextBox
            // 
            this.idProvinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "IdProvince", true));
            this.idProvinceTextBox.Location = new System.Drawing.Point(1208, 290);
            this.idProvinceTextBox.Name = "idProvinceTextBox";
            this.idProvinceTextBox.Size = new System.Drawing.Size(331, 38);
            this.idProvinceTextBox.TabIndex = 14;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(443, 229);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(289, 38);
            this.noCiviqueTextBox.TabIndex = 16;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(443, 114);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(289, 38);
            this.nomTextBox.TabIndex = 18;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(1208, 117);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(331, 38);
            this.prenomTextBox.TabIndex = 22;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(1208, 478);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(331, 38);
            this.remarqueTextBox.TabIndex = 24;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(1208, 232);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(331, 38);
            this.rueTextBox.TabIndex = 26;
            // 
            // sexeTextBox
            // 
            this.sexeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Sexe", true));
            this.sexeTextBox.Location = new System.Drawing.Point(443, 171);
            this.sexeTextBox.Name = "sexeTextBox";
            this.sexeTextBox.Size = new System.Drawing.Size(289, 38);
            this.sexeTextBox.TabIndex = 28;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(1208, 354);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(331, 38);
            this.telephoneTextBox.TabIndex = 30;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(443, 287);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(289, 38);
            this.villeTextBox.TabIndex = 32;
            // 
            // lblDateAbonnement
            // 
            this.lblDateAbonnement.AutoSize = true;
            this.lblDateAbonnement.Location = new System.Drawing.Point(443, 54);
            this.lblDateAbonnement.Name = "lblDateAbonnement";
            this.lblDateAbonnement.Size = new System.Drawing.Size(0, 32);
            this.lblDateAbonnement.TabIndex = 33;
            // 
            // cmbTypeAbonnement
            // 
            this.cmbTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.cmbTypeAbonnement.DisplayMember = "Description";
            this.cmbTypeAbonnement.FormattingEnabled = true;
            this.cmbTypeAbonnement.Location = new System.Drawing.Point(443, 487);
            this.cmbTypeAbonnement.Name = "cmbTypeAbonnement";
            this.cmbTypeAbonnement.Size = new System.Drawing.Size(346, 39);
            this.cmbTypeAbonnement.TabIndex = 34;
            this.cmbTypeAbonnement.ValueMember = "No";
            this.cmbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cmbTypeAbonnement_SelectedIndexChanged);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(TP2.TypesAbonnement);
            // 
            // frmAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 916);
            this.Controls.Add(this.cmbTypeAbonnement);
            this.Controls.Add(this.lblDateAbonnement);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.cellulaireTextBox);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(dateAbonnementLabel);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dateNaissanceDateTimePicker);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(this.idProvinceTextBox);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(noTypeAbonnementLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(this.sexeTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmAbonnement";
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.frmAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.TextBox cellulaireTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox idProvinceTextBox;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox sexeTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.Label lblDateAbonnement;
        private System.Windows.Forms.ComboBox cmbTypeAbonnement;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
    }
}