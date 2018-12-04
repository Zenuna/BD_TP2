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
            datePartieLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePartieLabel.Location = new System.Drawing.Point(68, 9);
            datePartieLabel.Name = "datePartieLabel";
            datePartieLabel.Size = new System.Drawing.Size(92, 19);
            datePartieLabel.TabIndex = 1;
            datePartieLabel.Text = "Date Partie:";
            // 
            // noTerrainLabel
            // 
            noTerrainLabel.AutoSize = true;
            noTerrainLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTerrainLabel.Location = new System.Drawing.Point(37, 38);
            noTerrainLabel.Name = "noTerrainLabel";
            noTerrainLabel.Size = new System.Drawing.Size(123, 19);
            noTerrainLabel.TabIndex = 5;
            noTerrainLabel.Text = "Nom du terrain:";
            noTerrainLabel.Click += new System.EventHandler(this.noTerrainLabel_Click);
            // 
            // pointageLabel
            // 
            pointageLabel.AutoSize = true;
            pointageLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pointageLabel.Location = new System.Drawing.Point(84, 104);
            pointageLabel.Name = "pointageLabel";
            pointageLabel.Size = new System.Drawing.Size(76, 19);
            pointageLabel.TabIndex = 7;
            pointageLabel.Text = "Pointage:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(73, 137);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(87, 19);
            remarqueLabel.TabIndex = 9;
            remarqueLabel.Text = "Remarque:";
            // 
            // idEtNomCompletLabel
            // 
            idEtNomCompletLabel.AutoSize = true;
            idEtNomCompletLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEtNomCompletLabel.Location = new System.Drawing.Point(12, 70);
            idEtNomCompletLabel.Name = "idEtNomCompletLabel";
            idEtNomCompletLabel.Size = new System.Drawing.Size(148, 19);
            idEtNomCompletLabel.TabIndex = 12;
            idEtNomCompletLabel.Text = "L\'abonné principal :";
            idEtNomCompletLabel.Click += new System.EventHandler(this.idEtNomCompletLabel_Click);
            // 
            // partiesJoueeBindingSource
            // 
            this.partiesJoueeBindingSource.DataSource = typeof(TP2.PartiesJouee);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueeBindingSource, "Remarque", true));
            this.remarqueTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(166, 133);
            this.remarqueTextBox.MaxLength = 50;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 27);
            this.remarqueTextBox.TabIndex = 10;
            this.remarqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbAbonne
            // 
            this.cmbAbonne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partiesJoueeBindingSource, "IdAbonnement", true));
            this.cmbAbonne.DataSource = this.nomCompletIDAbonneBindingSource;
            this.cmbAbonne.DisplayMember = "idEtNomComplet";
            this.cmbAbonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbonne.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAbonne.FormattingEnabled = true;
            this.cmbAbonne.Location = new System.Drawing.Point(166, 67);
            this.cmbAbonne.Name = "cmbAbonne";
            this.cmbAbonne.Size = new System.Drawing.Size(200, 27);
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
            this.cmbTerrain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerrain.FormattingEnabled = true;
            this.cmbTerrain.Location = new System.Drawing.Point(166, 34);
            this.cmbTerrain.Name = "cmbTerrain";
            this.cmbTerrain.Size = new System.Drawing.Size(200, 27);
            this.cmbTerrain.TabIndex = 12;
            this.cmbTerrain.ValueMember = "No";
            this.cmbTerrain.SelectedValueChanged += new System.EventHandler(this.cmbTerrain_SelectedValueChanged);
            // 
            // terrainBindingSource
            // 
            this.terrainBindingSource.DataSource = typeof(TP2.Terrain);
            // 
            // lblDatePartie
            // 
            this.lblDatePartie.AutoSize = true;
            this.lblDatePartie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePartie.Location = new System.Drawing.Point(166, 9);
            this.lblDatePartie.Name = "lblDatePartie";
            this.lblDatePartie.Size = new System.Drawing.Size(0, 19);
            this.lblDatePartie.TabIndex = 13;
            // 
            // nUDPointage
            // 
            this.nUDPointage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDPointage.Location = new System.Drawing.Point(166, 100);
            this.nUDPointage.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nUDPointage.Name = "nUDPointage";
            this.nUDPointage.Size = new System.Drawing.Size(200, 27);
            this.nUDPointage.TabIndex = 14;
            this.nUDPointage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEnregistrement
            // 
            this.btnEnregistrement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrement.Location = new System.Drawing.Point(95, 166);
            this.btnEnregistrement.Name = "btnEnregistrement";
            this.btnEnregistrement.Size = new System.Drawing.Size(219, 31);
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
            this.ClientSize = new System.Drawing.Size(408, 210);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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