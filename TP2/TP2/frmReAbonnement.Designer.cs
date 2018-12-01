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
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenouveler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(TP2.Abonnement);
            // 
            // dgAbonnement
            // 
            this.dgAbonnement.AllowUserToAddRows = false;
            this.dgAbonnement.AllowUserToDeleteRows = false;
            this.dgAbonnement.AutoGenerateColumns = false;
            this.dgAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgAbonnement.DataSource = this.abonnementBindingSource;
            this.dgAbonnement.Location = new System.Drawing.Point(12, 12);
            this.dgAbonnement.MultiSelect = false;
            this.dgAbonnement.Name = "dgAbonnement";
            this.dgAbonnement.ReadOnly = true;
            this.dgAbonnement.Size = new System.Drawing.Size(346, 220);
            this.dgAbonnement.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // frmReAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 309);
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
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.DataGridView dgAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenouveler;
    }
}