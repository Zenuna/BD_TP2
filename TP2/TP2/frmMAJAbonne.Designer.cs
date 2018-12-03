namespace TP2
{
    partial class frmMAJAbonne
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnementPrincipal = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDateAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCellulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeAbonnement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dependantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantDataGridView = new System.Windows.Forms.DataGridView();
            this.dgIdDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdAbonnementDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenomDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexeDep = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgDateNaissanceDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRemarqueDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(TP2.Abonnement);
            // 
            // dgAbonnementPrincipal
            // 
            this.dgAbonnementPrincipal.AllowUserToAddRows = false;
            this.dgAbonnementPrincipal.AllowUserToDeleteRows = false;
            this.dgAbonnementPrincipal.AutoGenerateColumns = false;
            this.dgAbonnementPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnementPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgDateAbonnement,
            this.dgPrenom,
            this.dgNom,
            this.dgSexe,
            this.dgDateNaissance,
            this.dgNoCivique,
            this.dgRue,
            this.dgVille,
            this.dataGridViewTextBoxColumn10,
            this.dgCodePostal,
            this.dgTelephone,
            this.dgCellulaire,
            this.dgCourriel,
            this.dgTypeAbonnement,
            this.dgRemarque});
            this.dgAbonnementPrincipal.DataSource = this.abonnementBindingSource;
            this.dgAbonnementPrincipal.Location = new System.Drawing.Point(12, 31);
            this.dgAbonnementPrincipal.Name = "dgAbonnementPrincipal";
            this.dgAbonnementPrincipal.Size = new System.Drawing.Size(945, 220);
            this.dgAbonnementPrincipal.TabIndex = 1;
            this.dgAbonnementPrincipal.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgAbonnementPrincipal_CellValidating);
            this.dgAbonnementPrincipal.SelectionChanged += new System.EventHandler(this.abonnementDataGridView_SelectionChanged);
            // 
            // dgID
            // 
            this.dgID.DataPropertyName = "Id";
            this.dgID.HeaderText = "ID";
            this.dgID.MaxInputLength = 50;
            this.dgID.Name = "dgID";
            this.dgID.ReadOnly = true;
            // 
            // dgDateAbonnement
            // 
            this.dgDateAbonnement.DataPropertyName = "DateAbonnement";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dgDateAbonnement.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDateAbonnement.HeaderText = "Date d\'abonnement";
            this.dgDateAbonnement.Name = "dgDateAbonnement";
            this.dgDateAbonnement.ReadOnly = true;
            // 
            // dgPrenom
            // 
            this.dgPrenom.DataPropertyName = "Prenom";
            this.dgPrenom.HeaderText = "Prénom";
            this.dgPrenom.MaxInputLength = 30;
            this.dgPrenom.Name = "dgPrenom";
            // 
            // dgNom
            // 
            this.dgNom.DataPropertyName = "Nom";
            this.dgNom.HeaderText = "Nom";
            this.dgNom.MaxInputLength = 30;
            this.dgNom.Name = "dgNom";
            this.dgNom.ReadOnly = true;
            // 
            // dgSexe
            // 
            this.dgSexe.DataPropertyName = "Sexe";
            this.dgSexe.DataSource = this.sexeBindingSource;
            this.dgSexe.DisplayMember = "Description";
            this.dgSexe.HeaderText = "Sexe";
            this.dgSexe.Name = "dgSexe";
            this.dgSexe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSexe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgSexe.ValueMember = "idSexe";
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(TP2.Sexe);
            // 
            // dgDateNaissance
            // 
            this.dgDateNaissance.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dgDateNaissance.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDateNaissance.HeaderText = "Date de naissance";
            this.dgDateNaissance.Name = "dgDateNaissance";
            this.dgDateNaissance.ReadOnly = true;
            // 
            // dgNoCivique
            // 
            this.dgNoCivique.DataPropertyName = "NoCivique";
            this.dgNoCivique.HeaderText = "Numéro civique";
            this.dgNoCivique.MaxInputLength = 10;
            this.dgNoCivique.Name = "dgNoCivique";
            // 
            // dgRue
            // 
            this.dgRue.DataPropertyName = "Rue";
            this.dgRue.HeaderText = "Rue";
            this.dgRue.MaxInputLength = 30;
            this.dgRue.Name = "dgRue";
            // 
            // dgVille
            // 
            this.dgVille.DataPropertyName = "Ville";
            this.dgVille.HeaderText = "Ville";
            this.dgVille.MaxInputLength = 30;
            this.dgVille.Name = "dgVille";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdProvince";
            this.dataGridViewTextBoxColumn10.DataSource = this.provinceBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "Nom";
            this.dataGridViewTextBoxColumn10.HeaderText = "Province";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "Id";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(TP2.Province);
            // 
            // dgCodePostal
            // 
            this.dgCodePostal.DataPropertyName = "CodePostal";
            this.dgCodePostal.HeaderText = "Code postal";
            this.dgCodePostal.MaxInputLength = 6;
            this.dgCodePostal.Name = "dgCodePostal";
            // 
            // dgTelephone
            // 
            this.dgTelephone.DataPropertyName = "Telephone";
            this.dgTelephone.HeaderText = "Téléphone";
            this.dgTelephone.MaxInputLength = 10;
            this.dgTelephone.Name = "dgTelephone";
            // 
            // dgCellulaire
            // 
            this.dgCellulaire.DataPropertyName = "Cellulaire";
            this.dgCellulaire.HeaderText = "Cellulaire";
            this.dgCellulaire.MaxInputLength = 10;
            this.dgCellulaire.Name = "dgCellulaire";
            // 
            // dgCourriel
            // 
            this.dgCourriel.DataPropertyName = "Courriel";
            this.dgCourriel.HeaderText = "Courriel";
            this.dgCourriel.MaxInputLength = 50;
            this.dgCourriel.Name = "dgCourriel";
            // 
            // dgTypeAbonnement
            // 
            this.dgTypeAbonnement.DataPropertyName = "NoTypeAbonnement";
            this.dgTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.dgTypeAbonnement.DisplayMember = "Description";
            this.dgTypeAbonnement.HeaderText = "Type d\'abonnement";
            this.dgTypeAbonnement.Name = "dgTypeAbonnement";
            this.dgTypeAbonnement.ReadOnly = true;
            this.dgTypeAbonnement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTypeAbonnement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTypeAbonnement.ValueMember = "No";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(TP2.TypesAbonnement);
            // 
            // dgRemarque
            // 
            this.dgRemarque.DataPropertyName = "Remarque";
            this.dgRemarque.HeaderText = "Remarque";
            this.dgRemarque.MaxInputLength = 50;
            this.dgRemarque.Name = "dgRemarque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonnés principaux:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abonnés dépendants:";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 502);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(346, 31);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(611, 502);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(346, 31);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dependantBindingSource
            // 
            this.dependantBindingSource.DataSource = typeof(TP2.Dependant);
            // 
            // dependantDataGridView
            // 
            this.dependantDataGridView.AllowUserToAddRows = false;
            this.dependantDataGridView.AllowUserToDeleteRows = false;
            this.dependantDataGridView.AutoGenerateColumns = false;
            this.dependantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dependantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dependantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdDep,
            this.dgIdAbonnementDep,
            this.dgNomDep,
            this.dgPrenomDep,
            this.dgSexeDep,
            this.dgDateNaissanceDep,
            this.dgRemarqueDep});
            this.dependantDataGridView.DataSource = this.dependantBindingSource;
            this.dependantDataGridView.Location = new System.Drawing.Point(12, 276);
            this.dependantDataGridView.Name = "dependantDataGridView";
            this.dependantDataGridView.Size = new System.Drawing.Size(945, 220);
            this.dependantDataGridView.TabIndex = 6;
            this.dependantDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dependantDataGridView_CellValidating);
            // 
            // dgIdDep
            // 
            this.dgIdDep.DataPropertyName = "Id";
            this.dgIdDep.HeaderText = "ID";
            this.dgIdDep.Name = "dgIdDep";
            this.dgIdDep.ReadOnly = true;
            // 
            // dgIdAbonnementDep
            // 
            this.dgIdAbonnementDep.DataPropertyName = "IdAbonnement";
            this.dgIdAbonnementDep.HeaderText = "ID d\'abonnement";
            this.dgIdAbonnementDep.Name = "dgIdAbonnementDep";
            this.dgIdAbonnementDep.ReadOnly = true;
            // 
            // dgNomDep
            // 
            this.dgNomDep.DataPropertyName = "Nom";
            this.dgNomDep.HeaderText = "Nom";
            this.dgNomDep.Name = "dgNomDep";
            // 
            // dgPrenomDep
            // 
            this.dgPrenomDep.DataPropertyName = "Prenom";
            this.dgPrenomDep.HeaderText = "Prénom";
            this.dgPrenomDep.Name = "dgPrenomDep";
            // 
            // dgSexeDep
            // 
            this.dgSexeDep.DataPropertyName = "Sexe";
            this.dgSexeDep.DataSource = this.sexeBindingSource;
            this.dgSexeDep.DisplayMember = "Description";
            this.dgSexeDep.HeaderText = "Sexe";
            this.dgSexeDep.Name = "dgSexeDep";
            this.dgSexeDep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSexeDep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgSexeDep.ValueMember = "idSexe";
            // 
            // dgDateNaissanceDep
            // 
            this.dgDateNaissanceDep.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle6.Format = "d";
            this.dgDateNaissanceDep.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgDateNaissanceDep.HeaderText = "Date de naissance";
            this.dgDateNaissanceDep.Name = "dgDateNaissanceDep";
            this.dgDateNaissanceDep.ReadOnly = true;
            // 
            // dgRemarqueDep
            // 
            this.dgRemarqueDep.DataPropertyName = "Remarque";
            this.dgRemarqueDep.HeaderText = "Remarque";
            this.dgRemarqueDep.Name = "dgRemarqueDep";
            // 
            // frmMAJAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 565);
            this.Controls.Add(this.dependantDataGridView);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAbonnementPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMAJAbonne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mise à jour des abonnés";
            this.Load += new System.EventHandler(this.frmMAJAbonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.DataGridView dgAbonnementPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.BindingSource dependantBindingSource;
        private System.Windows.Forms.DataGridView dependantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdAbonnementDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenomDep;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgSexeDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateNaissanceDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarqueDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNom;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNoCivique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVille;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCellulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCourriel;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarque;
    }
}