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
            dateDepenseLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDepenseLabel.Location = new System.Drawing.Point(124, 9);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(149, 19);
            dateDepenseLabel.TabIndex = 1;
            dateDepenseLabel.Text = "Date de la dépense:";
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montantLabel.Location = new System.Drawing.Point(201, 37);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new System.Drawing.Size(72, 19);
            montantLabel.TabIndex = 3;
            montantLabel.Text = "Montant:";
            // 
            // montantEffectuerLabel
            // 
            montantEffectuerLabel.AutoSize = true;
            montantEffectuerLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montantEffectuerLabel.Location = new System.Drawing.Point(140, 70);
            montantEffectuerLabel.Name = "montantEffectuerLabel";
            montantEffectuerLabel.Size = new System.Drawing.Size(132, 19);
            montantEffectuerLabel.TabIndex = 5;
            montantEffectuerLabel.Text = "Montant effectué:";
            // 
            // montantExigerLabel
            // 
            montantExigerLabel.AutoSize = true;
            montantExigerLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montantExigerLabel.Location = new System.Drawing.Point(158, 103);
            montantExigerLabel.Name = "montantExigerLabel";
            montantExigerLabel.Size = new System.Drawing.Size(114, 19);
            montantExigerLabel.TabIndex = 7;
            montantExigerLabel.Text = "Montant exigé:";
            // 
            // nomCompletAbPrincipalLabel
            // 
            nomCompletAbPrincipalLabel.AutoSize = true;
            nomCompletAbPrincipalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomCompletAbPrincipalLabel.Location = new System.Drawing.Point(12, 136);
            nomCompletAbPrincipalLabel.Name = "nomCompletAbPrincipalLabel";
            nomCompletAbPrincipalLabel.Size = new System.Drawing.Size(261, 19);
            nomCompletAbPrincipalLabel.TabIndex = 9;
            nomCompletAbPrincipalLabel.Text = "Nom complet de l\'abonné principal:";
            // 
            // nomCompletEmployeLabel
            // 
            nomCompletEmployeLabel.AutoSize = true;
            nomCompletEmployeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomCompletEmployeLabel.Location = new System.Drawing.Point(69, 169);
            nomCompletEmployeLabel.Name = "nomCompletEmployeLabel";
            nomCompletEmployeLabel.Size = new System.Drawing.Size(204, 19);
            nomCompletEmployeLabel.TabIndex = 11;
            nomCompletEmployeLabel.Text = "Nom complet de l\'employé:";
            // 
            // typeServiceLabel
            // 
            typeServiceLabel.AutoSize = true;
            typeServiceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeServiceLabel.Location = new System.Drawing.Point(132, 202);
            typeServiceLabel.Name = "typeServiceLabel";
            typeServiceLabel.Size = new System.Drawing.Size(125, 19);
            typeServiceLabel.TabIndex = 13;
            typeServiceLabel.Text = "Type de service:";
            // 
            // montantTextBox
            // 
            this.montantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "montant", true));
            this.montantTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantTextBox.Location = new System.Drawing.Point(279, 33);
            this.montantTextBox.Name = "montantTextBox";
            this.montantTextBox.ReadOnly = true;
            this.montantTextBox.Size = new System.Drawing.Size(200, 27);
            this.montantTextBox.TabIndex = 4;
            this.montantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // montantEffectuerTextBox
            // 
            this.montantEffectuerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "montantEffectuer", true));
            this.montantEffectuerTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantEffectuerTextBox.Location = new System.Drawing.Point(279, 66);
            this.montantEffectuerTextBox.Name = "montantEffectuerTextBox";
            this.montantEffectuerTextBox.ReadOnly = true;
            this.montantEffectuerTextBox.Size = new System.Drawing.Size(200, 27);
            this.montantEffectuerTextBox.TabIndex = 6;
            this.montantEffectuerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // montantExigerTextBox
            // 
            this.montantExigerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "montantExiger", true));
            this.montantExigerTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantExigerTextBox.Location = new System.Drawing.Point(278, 99);
            this.montantExigerTextBox.Name = "montantExigerTextBox";
            this.montantExigerTextBox.ReadOnly = true;
            this.montantExigerTextBox.Size = new System.Drawing.Size(200, 27);
            this.montantExigerTextBox.TabIndex = 8;
            this.montantExigerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nomCompletAbPrincipalTextBox
            // 
            this.nomCompletAbPrincipalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "nomCompletAbPrincipal", true));
            this.nomCompletAbPrincipalTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCompletAbPrincipalTextBox.Location = new System.Drawing.Point(279, 132);
            this.nomCompletAbPrincipalTextBox.Name = "nomCompletAbPrincipalTextBox";
            this.nomCompletAbPrincipalTextBox.ReadOnly = true;
            this.nomCompletAbPrincipalTextBox.Size = new System.Drawing.Size(200, 27);
            this.nomCompletAbPrincipalTextBox.TabIndex = 10;
            this.nomCompletAbPrincipalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nomCompletEmployeTextBox
            // 
            this.nomCompletEmployeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "nomCompletEmploye", true));
            this.nomCompletEmployeTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCompletEmployeTextBox.Location = new System.Drawing.Point(278, 165);
            this.nomCompletEmployeTextBox.Name = "nomCompletEmployeTextBox";
            this.nomCompletEmployeTextBox.ReadOnly = true;
            this.nomCompletEmployeTextBox.Size = new System.Drawing.Size(200, 27);
            this.nomCompletEmployeTextBox.TabIndex = 12;
            this.nomCompletEmployeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // typeServiceTextBox
            // 
            this.typeServiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationDepensesBindingSource, "typeService", true));
            this.typeServiceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeServiceTextBox.Location = new System.Drawing.Point(278, 198);
            this.typeServiceTextBox.Name = "typeServiceTextBox";
            this.typeServiceTextBox.ReadOnly = true;
            this.typeServiceTextBox.Size = new System.Drawing.Size(200, 27);
            this.typeServiceTextBox.TabIndex = 14;
            this.typeServiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDepense.Location = new System.Drawing.Point(279, 9);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(0, 19);
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
            this.ClientSize = new System.Drawing.Size(510, 248);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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