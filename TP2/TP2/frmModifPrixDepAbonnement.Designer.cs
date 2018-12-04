namespace TP2
{
    partial class frmModifPrixDepAbonnement
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgModPrixDep = new System.Windows.Forms.DataGridView();
            this.lblModificationBlock = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depensesObligatoires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modPrixDepenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgModPrixDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modPrixDepenseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 238);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(347, 30);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dgModPrixDep
            // 
            this.dgModPrixDep.AutoGenerateColumns = false;
            this.dgModPrixDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgModPrixDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModPrixDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.dataGridViewTextBoxColumn6,
            this.prix,
            this.depensesObligatoires});
            this.dgModPrixDep.DataSource = this.modPrixDepenseBindingSource2;
            this.dgModPrixDep.Location = new System.Drawing.Point(12, 12);
            this.dgModPrixDep.Name = "dgModPrixDep";
            this.dgModPrixDep.Size = new System.Drawing.Size(347, 220);
            this.dgModPrixDep.TabIndex = 1;
            this.dgModPrixDep.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgModPrixDep_CellValidating);
            // 
            // lblModificationBlock
            // 
            this.lblModificationBlock.AutoSize = true;
            this.lblModificationBlock.ForeColor = System.Drawing.Color.DarkRed;
            this.lblModificationBlock.Location = new System.Drawing.Point(38, 31);
            this.lblModificationBlock.Name = "lblModificationBlock";
            this.lblModificationBlock.Size = new System.Drawing.Size(0, 13);
            this.lblModificationBlock.TabIndex = 2;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix";
            this.prix.MaxInputLength = 12;
            this.prix.Name = "prix";
            this.prix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // depensesObligatoires
            // 
            this.depensesObligatoires.DataPropertyName = "depensesObligatoires";
            this.depensesObligatoires.HeaderText = "Dépenses obligatoires";
            this.depensesObligatoires.MaxInputLength = 12;
            this.depensesObligatoires.Name = "depensesObligatoires";
            this.depensesObligatoires.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // modPrixDepenseBindingSource2
            // 
            this.modPrixDepenseBindingSource2.DataSource = typeof(TP2.ModPrixDepense);
            // 
            // frmModifPrixDepAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 285);
            this.Controls.Add(this.lblModificationBlock);
            this.Controls.Add(this.dgModPrixDep);
            this.Controls.Add(this.btnEnregistrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifPrixDepAbonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification des prix et des dépenses d\'abonnement";
            this.Load += new System.EventHandler(this.frmModifPrixDepAbonnement_Load);
            this.Shown += new System.EventHandler(this.frmModifPrixDepAbonnement_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgModPrixDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modPrixDepenseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource modPrixDepenseBindingSource2;
        private System.Windows.Forms.DataGridView dgModPrixDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesObligatoires;
        private System.Windows.Forms.Label lblModificationBlock;
    }
}