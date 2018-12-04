namespace TP2
{
    partial class frmInformationsDepenses
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
            System.Windows.Forms.Label montantEffectuerLabel;
            System.Windows.Forms.Label montantExigerLabel;
            System.Windows.Forms.Label nomCompletAbPrincipalLabel;
            System.Windows.Forms.Label nomCompletEmployeLabel;
            System.Windows.Forms.Label typeServiceLabel;
            this.montantTextBox = new System.Windows.Forms.TextBox();
            this.montantEffectuerTextBox = new System.Windows.Forms.TextBox();
            this.montantExigerTextBox = new System.Windows.Forms.TextBox();
            this.nomCompletAbPrincipalTextBox = new System.Windows.Forms.TextBox();
            this.nomCompletEmployeTextBox = new System.Windows.Forms.TextBox();
            this.typeServiceTextBox = new System.Windows.Forms.TextBox();
            this.lblDateDepense = new System.Windows.Forms.Label();
            this.informationDepensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateDepenseLabel = new System.Windows.Forms.Label();
            montantLabel = new System.Windows.Forms.Label();
            montantEffectuerLabel = new System.Windows.Forms.Label();
            montantExigerLabel = new System.Windows.Forms.Label();
            nomCompletAbPrincipalLabel = new System.Windows.Forms.Label();
            nomCompletEmployeLabel = new System.Windows.Forms.Label();
            typeServiceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informationDepensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDepenseLabel
            // 
            dateDepenseLabel.AutoSize = true;
            dateDepenseLabel.Location = new System.Drawing.Point(39, 45);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(103, 13);
            dateDepenseLabel.TabIndex = 1;
            dateDepenseLabel.Text = "Date de la dépense:";
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Location = new System.Drawing.Point(39, 70);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new System.Drawing.Size(49, 13);
            montantLabel.TabIndex = 3;
            montantLabel.Text = "Montant:";
            // 
            // montantTextBox
            // 
            this.montantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "montant", true));
            this.montantTextBox.Location = new System.Drawing.Point(217, 67);
            this.montantTextBox.Name = "montantTextBox";
            this.montantTextBox.ReadOnly = true;
            this.montantTextBox.Size = new System.Drawing.Size(200, 20);
            this.montantTextBox.TabIndex = 4;
            // 
            // montantEffectuerLabel
            // 
            montantEffectuerLabel.AutoSize = true;
            montantEffectuerLabel.Location = new System.Drawing.Point(39, 96);
            montantEffectuerLabel.Name = "montantEffectuerLabel";
            montantEffectuerLabel.Size = new System.Drawing.Size(92, 13);
            montantEffectuerLabel.TabIndex = 5;
            montantEffectuerLabel.Text = "Montant Effectué:";
            // 
            // montantEffectuerTextBox
            // 
            this.montantEffectuerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "montantEffectuer", true));
            this.montantEffectuerTextBox.Location = new System.Drawing.Point(217, 93);
            this.montantEffectuerTextBox.Name = "montantEffectuerTextBox";
            this.montantEffectuerTextBox.ReadOnly = true;
            this.montantEffectuerTextBox.Size = new System.Drawing.Size(200, 20);
            this.montantEffectuerTextBox.TabIndex = 6;
            // 
            // montantExigerLabel
            // 
            montantExigerLabel.AutoSize = true;
            montantExigerLabel.Location = new System.Drawing.Point(39, 122);
            montantExigerLabel.Name = "montantExigerLabel";
            montantExigerLabel.Size = new System.Drawing.Size(78, 13);
            montantExigerLabel.TabIndex = 7;
            montantExigerLabel.Text = "Montant Exigé:";
            // 
            // montantExigerTextBox
            // 
            this.montantExigerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "montantExiger", true));
            this.montantExigerTextBox.Location = new System.Drawing.Point(217, 119);
            this.montantExigerTextBox.Name = "montantExigerTextBox";
            this.montantExigerTextBox.ReadOnly = true;
            this.montantExigerTextBox.Size = new System.Drawing.Size(200, 20);
            this.montantExigerTextBox.TabIndex = 8;
            // 
            // nomCompletAbPrincipalLabel
            // 
            nomCompletAbPrincipalLabel.AutoSize = true;
            nomCompletAbPrincipalLabel.Location = new System.Drawing.Point(39, 148);
            nomCompletAbPrincipalLabel.Name = "nomCompletAbPrincipalLabel";
            nomCompletAbPrincipalLabel.Size = new System.Drawing.Size(172, 13);
            nomCompletAbPrincipalLabel.TabIndex = 9;
            nomCompletAbPrincipalLabel.Text = "Nom complet de l\'abonné principal:";
            // 
            // nomCompletAbPrincipalTextBox
            // 
            this.nomCompletAbPrincipalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "nomCompletAbPrincipal", true));
            this.nomCompletAbPrincipalTextBox.Location = new System.Drawing.Point(217, 145);
            this.nomCompletAbPrincipalTextBox.Name = "nomCompletAbPrincipalTextBox";
            this.nomCompletAbPrincipalTextBox.ReadOnly = true;
            this.nomCompletAbPrincipalTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomCompletAbPrincipalTextBox.TabIndex = 10;
            // 
            // nomCompletEmployeLabel
            // 
            nomCompletEmployeLabel.AutoSize = true;
            nomCompletEmployeLabel.Location = new System.Drawing.Point(39, 174);
            nomCompletEmployeLabel.Name = "nomCompletEmployeLabel";
            nomCompletEmployeLabel.Size = new System.Drawing.Size(133, 13);
            nomCompletEmployeLabel.TabIndex = 11;
            nomCompletEmployeLabel.Text = "Nom complet de l\'employé:";
            // 
            // nomCompletEmployeTextBox
            // 
            this.nomCompletEmployeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "nomCompletEmploye", true));
            this.nomCompletEmployeTextBox.Location = new System.Drawing.Point(217, 171);
            this.nomCompletEmployeTextBox.Name = "nomCompletEmployeTextBox";
            this.nomCompletEmployeTextBox.ReadOnly = true;
            this.nomCompletEmployeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomCompletEmployeTextBox.TabIndex = 12;
            // 
            // typeServiceLabel
            // 
            typeServiceLabel.AutoSize = true;
            typeServiceLabel.Location = new System.Drawing.Point(39, 200);
            typeServiceLabel.Name = "typeServiceLabel";
            typeServiceLabel.Size = new System.Drawing.Size(97, 13);
            typeServiceLabel.TabIndex = 13;
            typeServiceLabel.Text = "Le type de service:";
            // 
            // typeServiceTextBox
            // 
            this.typeServiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "typeService", true));
            this.typeServiceTextBox.Location = new System.Drawing.Point(217, 197);
            this.typeServiceTextBox.Name = "typeServiceTextBox";
            this.typeServiceTextBox.ReadOnly = true;
            this.typeServiceTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeServiceTextBox.TabIndex = 14;
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Location = new System.Drawing.Point(217, 45);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(0, 13);
            this.lblDateDepense.TabIndex = 15;
            // 
            // informationDepensesBindingSource
            // 
            this.informationDepensesBindingSource.DataSource = typeof(TP2.InformationDepenses);
            // 
            // frmInformationsDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 264);
            this.Controls.Add(this.lblDateDepense);
            this.Controls.Add(dateDepenseLabel);
            this.Controls.Add(montantLabel);
            this.Controls.Add(this.montantTextBox);
            this.Controls.Add(montantEffectuerLabel);
            this.Controls.Add(this.montantEffectuerTextBox);
            this.Controls.Add(montantExigerLabel);
            this.Controls.Add(this.montantExigerTextBox);
            this.Controls.Add(nomCompletAbPrincipalLabel);
            this.Controls.Add(this.nomCompletAbPrincipalTextBox);
            this.Controls.Add(nomCompletEmployeLabel);
            this.Controls.Add(this.nomCompletEmployeTextBox);
            this.Controls.Add(typeServiceLabel);
            this.Controls.Add(this.typeServiceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInformationsDepenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informations sur les dépenses";
            this.Load += new System.EventHandler(this.frmInformationsDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationDepensesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource informationDepensesBindingSource;
        private System.Windows.Forms.TextBox montantTextBox;
        private System.Windows.Forms.TextBox montantEffectuerTextBox;
        private System.Windows.Forms.TextBox montantExigerTextBox;
        private System.Windows.Forms.TextBox nomCompletAbPrincipalTextBox;
        private System.Windows.Forms.TextBox nomCompletEmployeTextBox;
        private System.Windows.Forms.TextBox typeServiceTextBox;
        private System.Windows.Forms.Label lblDateDepense;
    }
}