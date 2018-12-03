namespace TP2
{
    partial class frmInscriptionPartieGolf
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
            System.Windows.Forms.Label datePartieLabel;
            System.Windows.Forms.Label noTerrainLabel;
            System.Windows.Forms.Label pointageLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label idEtNomCompletLabel;
            this.partiesJoueeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.cmbAbonne = new System.Windows.Forms.ComboBox();
            this.nomCompletIDAbonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTerrain = new System.Windows.Forms.ComboBox();
            this.terrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDatePartie = new System.Windows.Forms.Label();
            this.nUDPointage = new System.Windows.Forms.NumericUpDown();
            this.btnEnregistrement = new System.Windows.Forms.Button();
            datePartieLabel = new System.Windows.Forms.Label();
            noTerrainLabel = new System.Windows.Forms.Label();
            pointageLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            idEtNomCompletLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomCompletIDAbonneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPointage)).BeginInit();
            this.SuspendLayout();
            // 
            // datePartieLabel
            // 
            datePartieLabel.AutoSize = true;
            datePartieLabel.Location = new System.Drawing.Point(70, 69);
            datePartieLabel.Name = "datePartieLabel";
            datePartieLabel.Size = new System.Drawing.Size(63, 13);
            datePartieLabel.TabIndex = 1;
            datePartieLabel.Text = "Date Partie:";
            // 
            // noTerrainLabel
            // 
            noTerrainLabel.AutoSize = true;
            noTerrainLabel.Location = new System.Drawing.Point(54, 121);
            noTerrainLabel.Name = "noTerrainLabel";
            noTerrainLabel.Size = new System.Drawing.Size(79, 13);
            noTerrainLabel.TabIndex = 5;
            noTerrainLabel.Text = "Nom du terrain:";
            // 
            // pointageLabel
            // 
            pointageLabel.AutoSize = true;
            pointageLabel.Location = new System.Drawing.Point(81, 147);
            pointageLabel.Name = "pointageLabel";
            pointageLabel.Size = new System.Drawing.Size(52, 13);
            pointageLabel.TabIndex = 7;
            pointageLabel.Text = "Pointage:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(74, 173);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 9;
            remarqueLabel.Text = "Remarque:";
            // 
            // idEtNomCompletLabel
            // 
            idEtNomCompletLabel.AutoSize = true;
            idEtNomCompletLabel.Location = new System.Drawing.Point(34, 94);
            idEtNomCompletLabel.Name = "idEtNomCompletLabel";
            idEtNomCompletLabel.Size = new System.Drawing.Size(99, 13);
            idEtNomCompletLabel.TabIndex = 12;
            idEtNomCompletLabel.Text = "L\'abonné principal :";
            // 
            // partiesJoueeBindingSource
            // 
            this.partiesJoueeBindingSource.DataSource = typeof(TP2.PartiesJouee);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueeBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(155, 171);
            this.remarqueTextBox.MaxLength = 50;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox.TabIndex = 10;
            this.remarqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbAbonne
            // 
            this.cmbAbonne.DataSource = this.nomCompletIDAbonneBindingSource;
            this.cmbAbonne.DisplayMember = "idEtNomComplet";
            this.cmbAbonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbonne.FormattingEnabled = true;
            this.cmbAbonne.Location = new System.Drawing.Point(155, 91);
            this.cmbAbonne.Name = "cmbAbonne";
            this.cmbAbonne.Size = new System.Drawing.Size(200, 21);
            this.cmbAbonne.TabIndex = 11;
            this.cmbAbonne.ValueMember = "idAbonnement";
            // 
            // nomCompletIDAbonneBindingSource
            // 
            this.nomCompletIDAbonneBindingSource.DataSource = typeof(TP2.nomCompletIDAbonne);
            // 
            // cmbTerrain
            // 
            this.cmbTerrain.DataSource = this.terrainBindingSource;
            this.cmbTerrain.DisplayMember = "Nom";
            this.cmbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerrain.FormattingEnabled = true;
            this.cmbTerrain.Location = new System.Drawing.Point(155, 118);
            this.cmbTerrain.Name = "cmbTerrain";
            this.cmbTerrain.Size = new System.Drawing.Size(200, 21);
            this.cmbTerrain.TabIndex = 12;
            this.cmbTerrain.ValueMember = "No";
            // 
            // terrainBindingSource
            // 
            this.terrainBindingSource.DataSource = typeof(TP2.Terrain);
            // 
            // lblDatePartie
            // 
            this.lblDatePartie.AutoSize = true;
            this.lblDatePartie.Location = new System.Drawing.Point(158, 70);
            this.lblDatePartie.Name = "lblDatePartie";
            this.lblDatePartie.Size = new System.Drawing.Size(0, 13);
            this.lblDatePartie.TabIndex = 13;
            // 
            // nUDPointage
            // 
            this.nUDPointage.Location = new System.Drawing.Point(155, 145);
            this.nUDPointage.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nUDPointage.Name = "nUDPointage";
            this.nUDPointage.Size = new System.Drawing.Size(200, 20);
            this.nUDPointage.TabIndex = 14;
            this.nUDPointage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEnregistrement
            // 
            this.btnEnregistrement.Location = new System.Drawing.Point(155, 218);
            this.btnEnregistrement.Name = "btnEnregistrement";
            this.btnEnregistrement.Size = new System.Drawing.Size(155, 31);
            this.btnEnregistrement.TabIndex = 15;
            this.btnEnregistrement.Text = "Enregistrer la partie";
            this.btnEnregistrement.UseVisualStyleBackColor = true;
            this.btnEnregistrement.Click += new System.EventHandler(this.btnEnregistrement_Click);
            // 
            // frmInscriptionPartieGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(408, 310);
            this.Controls.Add(this.btnEnregistrement);
            this.Controls.Add(this.nUDPointage);
            this.Controls.Add(this.lblDatePartie);
            this.Controls.Add(idEtNomCompletLabel);
            this.Controls.Add(this.cmbTerrain);
            this.Controls.Add(this.cmbAbonne);
            this.Controls.Add(datePartieLabel);
            this.Controls.Add(noTerrainLabel);
            this.Controls.Add(pointageLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInscriptionPartieGolf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription d\'une partie de golf jouée";
            this.Load += new System.EventHandler(this.frmInscriptionPartieGolf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomCompletIDAbonneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPointage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partiesJoueeBindingSource;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.ComboBox cmbAbonne;
        private System.Windows.Forms.ComboBox cmbTerrain;
        private System.Windows.Forms.BindingSource terrainBindingSource;
        private System.Windows.Forms.BindingSource nomCompletIDAbonneBindingSource;
        private System.Windows.Forms.Label lblDatePartie;
        private System.Windows.Forms.NumericUpDown nUDPointage;
        private System.Windows.Forms.Button btnEnregistrement;
    }
}