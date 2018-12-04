namespace TP2
{
    partial class frmInscriptionDepense
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
            System.Windows.Forms.Label dateDepenseLabel;
            System.Windows.Forms.Label montantLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label nomCompletLabel;
            this.depenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.cmbAbonnePrincipal = new System.Windows.Forms.ComboBox();
            this.nomCompletIDAbonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDateDepense = new System.Windows.Forms.Label();
            this.maskedMontant = new System.Windows.Forms.MaskedTextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAjoutDepense = new System.Windows.Forms.Button();
            this.cmbTypeService = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblService = new System.Windows.Forms.Label();
            dateDepenseLabel = new System.Windows.Forms.Label();
            montantLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            nomCompletLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomCompletIDAbonneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDepenseLabel
            // 
            dateDepenseLabel.AutoSize = true;
            dateDepenseLabel.Location = new System.Drawing.Point(72, 47);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(79, 13);
            dateDepenseLabel.TabIndex = 1;
            dateDepenseLabel.Text = "Date Depense:";
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Location = new System.Drawing.Point(72, 98);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new System.Drawing.Size(49, 13);
            montantLabel.TabIndex = 5;
            montantLabel.Text = "Montant:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(72, 124);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 11;
            remarqueLabel.Text = "Remarque:";
            // 
            // nomCompletLabel
            // 
            nomCompletLabel.AutoSize = true;
            nomCompletLabel.Location = new System.Drawing.Point(72, 69);
            nomCompletLabel.Name = "nomCompletLabel";
            nomCompletLabel.Size = new System.Drawing.Size(130, 13);
            nomCompletLabel.TabIndex = 12;
            nomCompletLabel.Text = "Nom complet de l\'abonné:";
            // 
            // depenseBindingSource
            // 
            this.depenseBindingSource.DataSource = typeof(TP2.Depense);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depenseBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(219, 124);
            this.remarqueTextBox.MaxLength = 50;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox.TabIndex = 12;
            // 
            // cmbAbonnePrincipal
            // 
            this.cmbAbonnePrincipal.DataSource = this.nomCompletIDAbonneBindingSource;
            this.cmbAbonnePrincipal.DisplayMember = "idEtNomComplet";
            this.cmbAbonnePrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbonnePrincipal.FormattingEnabled = true;
            this.cmbAbonnePrincipal.Location = new System.Drawing.Point(219, 66);
            this.cmbAbonnePrincipal.Name = "cmbAbonnePrincipal";
            this.cmbAbonnePrincipal.Size = new System.Drawing.Size(200, 21);
            this.cmbAbonnePrincipal.TabIndex = 14;
            this.cmbAbonnePrincipal.ValueMember = "idAbonnement";
            // 
            // nomCompletIDAbonneBindingSource
            // 
            this.nomCompletIDAbonneBindingSource.DataSource = typeof(TP2.nomCompletIDAbonne);
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Location = new System.Drawing.Point(225, 47);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(0, 13);
            this.lblDateDepense.TabIndex = 15;
            // 
            // maskedMontant
            // 
            this.maskedMontant.Location = new System.Drawing.Point(219, 93);
            this.maskedMontant.Mask = "0000.00$";
            this.maskedMontant.Name = "maskedMontant";
            this.maskedMontant.Size = new System.Drawing.Size(57, 20);
            this.maskedMontant.TabIndex = 16;
            this.maskedMontant.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedMontant.Validating += new System.ComponentModel.CancelEventHandler(this.maskedMontant_Validating);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnAjoutDepense
            // 
            this.btnAjoutDepense.Location = new System.Drawing.Point(219, 177);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(157, 23);
            this.btnAjoutDepense.TabIndex = 17;
            this.btnAjoutDepense.Text = "Ajouter une dépense";
            this.btnAjoutDepense.UseVisualStyleBackColor = true;
            this.btnAjoutDepense.Click += new System.EventHandler(this.btnAjoutDepense_Click);
            // 
            // cmbTypeService
            // 
            this.cmbTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeService.FormattingEnabled = true;
            this.cmbTypeService.Location = new System.Drawing.Point(219, 150);
            this.cmbTypeService.Name = "cmbTypeService";
            this.cmbTypeService.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeService.TabIndex = 18;
            this.cmbTypeService.Visible = false;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(TP2.Service);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(75, 157);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(76, 13);
            this.lblService.TabIndex = 19;
            this.lblService.Text = "Type Service :";
            this.lblService.Visible = false;
            // 
            // frmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 216);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cmbTypeService);
            this.Controls.Add(this.btnAjoutDepense);
            this.Controls.Add(this.maskedMontant);
            this.Controls.Add(this.lblDateDepense);
            this.Controls.Add(this.cmbAbonnePrincipal);
            this.Controls.Add(nomCompletLabel);
            this.Controls.Add(dateDepenseLabel);
            this.Controls.Add(montantLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInscriptionDepense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription d\'une dépense";
            this.Load += new System.EventHandler(this.frmInscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomCompletIDAbonneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource depenseBindingSource;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.ComboBox cmbAbonnePrincipal;
        private System.Windows.Forms.BindingSource nomCompletIDAbonneBindingSource;
        private System.Windows.Forms.Label lblDateDepense;
        private System.Windows.Forms.MaskedTextBox maskedMontant;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.ComboBox cmbTypeService;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.Label lblService;
    }
}