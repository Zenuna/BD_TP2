namespace TP2
{
    partial class frmMenu
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
            this.btnGestEmp = new System.Windows.Forms.Button();
            this.btnAbonnement = new System.Windows.Forms.Button();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.btnMAJAbonne = new System.Windows.Forms.Button();
            this.btnModifMontantAbonnement = new System.Windows.Forms.Button();
            this.btnInscriptionPartieGolf = new System.Windows.Forms.Button();
            this.btnInscriptionDepense = new System.Windows.Forms.Button();
            this.btnVisualisationRapport = new System.Windows.Forms.Button();
            this.btnVisualisationStats = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestEmp
            // 
            this.btnGestEmp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEmp.Location = new System.Drawing.Point(13, 13);
            this.btnGestEmp.Name = "btnGestEmp";
            this.btnGestEmp.Size = new System.Drawing.Size(333, 35);
            this.btnGestEmp.TabIndex = 0;
            this.btnGestEmp.Text = "Gestion des employés";
            this.btnGestEmp.UseVisualStyleBackColor = true;
            this.btnGestEmp.Click += new System.EventHandler(this.btnGestEmp_Click);
            // 
            // btnAbonnement
            // 
            this.btnAbonnement.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbonnement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonnement.Location = new System.Drawing.Point(12, 54);
            this.btnAbonnement.Name = "btnAbonnement";
            this.btnAbonnement.Size = new System.Drawing.Size(333, 35);
            this.btnAbonnement.TabIndex = 1;
            this.btnAbonnement.Text = "Abonnement";
            this.btnAbonnement.UseVisualStyleBackColor = true;
            this.btnAbonnement.Click += new System.EventHandler(this.btnAbonnement_Click);
            // 
            // btnReabonnement
            // 
            this.btnReabonnement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReabonnement.Location = new System.Drawing.Point(13, 95);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(333, 35);
            this.btnReabonnement.TabIndex = 2;
            this.btnReabonnement.Text = "Réabonnement";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // btnMAJAbonne
            // 
            this.btnMAJAbonne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAJAbonne.Location = new System.Drawing.Point(12, 136);
            this.btnMAJAbonne.Name = "btnMAJAbonne";
            this.btnMAJAbonne.Size = new System.Drawing.Size(333, 35);
            this.btnMAJAbonne.TabIndex = 3;
            this.btnMAJAbonne.Text = "Mise à jour des abonnés";
            this.btnMAJAbonne.UseVisualStyleBackColor = true;
            this.btnMAJAbonne.Click += new System.EventHandler(this.btnMAJAbonne_Click);
            // 
            // btnModifMontantAbonnement
            // 
            this.btnModifMontantAbonnement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifMontantAbonnement.Location = new System.Drawing.Point(12, 177);
            this.btnModifMontantAbonnement.Name = "btnModifMontantAbonnement";
            this.btnModifMontantAbonnement.Size = new System.Drawing.Size(333, 35);
            this.btnModifMontantAbonnement.TabIndex = 4;
            this.btnModifMontantAbonnement.Text = "Modification des prix et des dépenses d\'abonnement";
            this.btnModifMontantAbonnement.UseVisualStyleBackColor = true;
            this.btnModifMontantAbonnement.Click += new System.EventHandler(this.btnModifMontantAbonnement_Click);
            // 
            // btnInscriptionPartieGolf
            // 
            this.btnInscriptionPartieGolf.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionPartieGolf.Location = new System.Drawing.Point(12, 218);
            this.btnInscriptionPartieGolf.Name = "btnInscriptionPartieGolf";
            this.btnInscriptionPartieGolf.Size = new System.Drawing.Size(333, 35);
            this.btnInscriptionPartieGolf.TabIndex = 5;
            this.btnInscriptionPartieGolf.Text = "Inscription d\'une partie de golf jouée";
            this.btnInscriptionPartieGolf.UseVisualStyleBackColor = true;
            this.btnInscriptionPartieGolf.Click += new System.EventHandler(this.btnInscriptionPartieGolf_Click);
            // 
            // btnInscriptionDepense
            // 
            this.btnInscriptionDepense.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionDepense.Location = new System.Drawing.Point(12, 259);
            this.btnInscriptionDepense.Name = "btnInscriptionDepense";
            this.btnInscriptionDepense.Size = new System.Drawing.Size(333, 35);
            this.btnInscriptionDepense.TabIndex = 6;
            this.btnInscriptionDepense.Text = "Inscription d\'une dépense";
            this.btnInscriptionDepense.UseVisualStyleBackColor = true;
            this.btnInscriptionDepense.Click += new System.EventHandler(this.btnInscriptionDepense_Click);
            // 
            // btnVisualisationRapport
            // 
            this.btnVisualisationRapport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualisationRapport.Location = new System.Drawing.Point(12, 300);
            this.btnVisualisationRapport.Name = "btnVisualisationRapport";
            this.btnVisualisationRapport.Size = new System.Drawing.Size(333, 35);
            this.btnVisualisationRapport.TabIndex = 7;
            this.btnVisualisationRapport.Text = "Visualisation des rapports";
            this.btnVisualisationRapport.UseVisualStyleBackColor = true;
            this.btnVisualisationRapport.Click += new System.EventHandler(this.btnVisualisationRapport_Click);
            // 
            // btnVisualisationStats
            // 
            this.btnVisualisationStats.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVisualisationStats.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualisationStats.Location = new System.Drawing.Point(12, 341);
            this.btnVisualisationStats.Name = "btnVisualisationStats";
            this.btnVisualisationStats.Size = new System.Drawing.Size(333, 35);
            this.btnVisualisationStats.TabIndex = 8;
            this.btnVisualisationStats.Text = "Visualisation des statistiques";
            this.btnVisualisationStats.UseVisualStyleBackColor = true;
            this.btnVisualisationStats.Click += new System.EventHandler(this.btnVisualisationStats_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(12, 382);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(333, 35);
            this.btnDeconnexion.TabIndex = 9;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(333, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Fermer le système";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 467);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnVisualisationStats);
            this.Controls.Add(this.btnVisualisationRapport);
            this.Controls.Add(this.btnInscriptionDepense);
            this.Controls.Add(this.btnInscriptionPartieGolf);
            this.Controls.Add(this.btnModifMontantAbonnement);
            this.Controls.Add(this.btnMAJAbonne);
            this.Controls.Add(this.btnReabonnement);
            this.Controls.Add(this.btnAbonnement);
            this.Controls.Add(this.btnGestEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestEmp;
        private System.Windows.Forms.Button btnAbonnement;
        private System.Windows.Forms.Button btnReabonnement;
        private System.Windows.Forms.Button btnMAJAbonne;
        private System.Windows.Forms.Button btnModifMontantAbonnement;
        private System.Windows.Forms.Button btnInscriptionPartieGolf;
        private System.Windows.Forms.Button btnInscriptionDepense;
        private System.Windows.Forms.Button btnVisualisationRapport;
        private System.Windows.Forms.Button btnVisualisationStats;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnExit;
    }
}