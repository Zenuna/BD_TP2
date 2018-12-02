namespace TP2
{
    partial class frmReAbonnement
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
            this.dgAbonnement = new System.Windows.Forms.DataGridView();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenouveler = new System.Windows.Forms.Button();
            this.btbRetour = new System.Windows.Forms.Button();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCompletAbonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomCompletAbonneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAbonnement
            // 
            this.dgAbonnement.AllowUserToAddRows = false;
            this.dgAbonnement.AllowUserToDeleteRows = false;
            this.dgAbonnement.AutoGenerateColumns = false;
            this.dgAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgNomComplet});
            this.dgAbonnement.DataSource = this.nomCompletAbonneBindingSource;
            this.dgAbonnement.Location = new System.Drawing.Point(12, 12);
            this.dgAbonnement.MultiSelect = false;
            this.dgAbonnement.Name = "dgAbonnement";
            this.dgAbonnement.ReadOnly = true;
            this.dgAbonnement.Size = new System.Drawing.Size(346, 220);
            this.dgAbonnement.TabIndex = 1;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(105, 238);
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(253, 27);
            this.tbRemarque.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remarque:";
            // 
            // btnRenouveler
            // 
            this.btnRenouveler.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenouveler.Location = new System.Drawing.Point(12, 271);
            this.btnRenouveler.Name = "btnRenouveler";
            this.btnRenouveler.Size = new System.Drawing.Size(346, 31);
            this.btnRenouveler.TabIndex = 4;
            this.btnRenouveler.Text = "Renouveler l\'abonnement sélectionné";
            this.btnRenouveler.UseVisualStyleBackColor = true;
            this.btnRenouveler.Click += new System.EventHandler(this.btnRenouveler_Click);
            // 
            // btbRetour
            // 
            this.btbRetour.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbRetour.Location = new System.Drawing.Point(12, 308);
            this.btbRetour.Name = "btbRetour";
            this.btbRetour.Size = new System.Drawing.Size(346, 31);
            this.btbRetour.TabIndex = 5;
            this.btbRetour.Text = "Retourner au menu";
            this.btbRetour.UseVisualStyleBackColor = true;
            this.btbRetour.Click += new System.EventHandler(this.btbRetour_Click);
            // 
            // dgID
            // 
            this.dgID.DataPropertyName = "idAbonne";
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            this.dgID.ReadOnly = true;
            // 
            // dgNomComplet
            // 
            this.dgNomComplet.DataPropertyName = "nomComplet";
            this.dgNomComplet.HeaderText = "Nom complet";
            this.dgNomComplet.Name = "dgNomComplet";
            this.dgNomComplet.ReadOnly = true;
            // 
            // nomCompletAbonneBindingSource
            // 
            this.nomCompletAbonneBindingSource.DataSource = typeof(TP2.nomCompletAbonne);
            // 
            // frmReAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 345);
            this.Controls.Add(this.btbRetour);
            this.Controls.Add(this.btnRenouveler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.dgAbonnement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReAbonnement";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réabonnement";
            this.Load += new System.EventHandler(this.frmReAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomCompletAbonneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgAbonnement;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenouveler;
        private System.Windows.Forms.Button btbRetour;
        private System.Windows.Forms.BindingSource nomCompletAbonneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomComplet;
    }
}