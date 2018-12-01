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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnementPrincipal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAbonnementDependant = new System.Windows.Forms.DataGridView();
            this.abonnementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgIDDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDateAbonnementDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenomDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgDateNaissanceDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNoCiviqueDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRueDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVilleDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProvinceDep = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgCodePostalDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelephoneDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCellulaireDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCourrielDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeAbonnementDep = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDateAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgDateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCellulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeAbonnement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementDependant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
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
            this.dataGridViewTextBoxColumn16});
            this.dgAbonnementPrincipal.DataSource = this.abonnementBindingSource;
            this.dgAbonnementPrincipal.Location = new System.Drawing.Point(12, 31);
            this.dgAbonnementPrincipal.Name = "dgAbonnementPrincipal";
            this.dgAbonnementPrincipal.Size = new System.Drawing.Size(945, 220);
            this.dgAbonnementPrincipal.TabIndex = 1;
            this.dgAbonnementPrincipal.SelectionChanged += new System.EventHandler(this.abonnementDataGridView_SelectionChanged);
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
            // dgAbonnementDependant
            // 
            this.dgAbonnementDependant.AllowUserToAddRows = false;
            this.dgAbonnementDependant.AllowUserToDeleteRows = false;
            this.dgAbonnementDependant.AutoGenerateColumns = false;
            this.dgAbonnementDependant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnementDependant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIDDep,
            this.dgDateAbonnementDep,
            this.dgPrenomDep,
            this.dgNomDep,
            this.dataGridViewTextBoxColumn24,
            this.dgDateNaissanceDep,
            this.dgNoCiviqueDep,
            this.dgRueDep,
            this.dgVilleDep,
            this.dgProvinceDep,
            this.dgCodePostalDep,
            this.dgTelephoneDep,
            this.dgCellulaireDep,
            this.dgCourrielDep,
            this.dgTypeAbonnementDep,
            this.dgRemarque});
            this.dgAbonnementDependant.DataSource = this.abonnementBindingSource1;
            this.dgAbonnementDependant.Location = new System.Drawing.Point(12, 276);
            this.dgAbonnementDependant.Name = "dgAbonnementDependant";
            this.dgAbonnementDependant.Size = new System.Drawing.Size(945, 220);
            this.dgAbonnementDependant.TabIndex = 3;
            // 
            // abonnementBindingSource1
            // 
            this.abonnementBindingSource1.DataSource = typeof(TP2.Abonnement);
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(TP2.Sexe);
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(TP2.Province);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(TP2.TypesAbonnement);
            // 
            // dgIDDep
            // 
            this.dgIDDep.DataPropertyName = "Id";
            this.dgIDDep.HeaderText = "ID";
            this.dgIDDep.MaxInputLength = 30;
            this.dgIDDep.Name = "dgIDDep";
            this.dgIDDep.ReadOnly = true;
            // 
            // dgDateAbonnementDep
            // 
            this.dgDateAbonnementDep.DataPropertyName = "DateAbonnement";
            dataGridViewCellStyle9.Format = "d";
            this.dgDateAbonnementDep.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgDateAbonnementDep.HeaderText = "Date d\'abonnement";
            this.dgDateAbonnementDep.Name = "dgDateAbonnementDep";
            // 
            // dgPrenomDep
            // 
            this.dgPrenomDep.DataPropertyName = "Prenom";
            this.dgPrenomDep.HeaderText = "Prénom";
            this.dgPrenomDep.MaxInputLength = 30;
            this.dgPrenomDep.Name = "dgPrenomDep";
            // 
            // dgNomDep
            // 
            this.dgNomDep.DataPropertyName = "Nom";
            this.dgNomDep.HeaderText = "Nom";
            this.dgNomDep.MaxInputLength = 30;
            this.dgNomDep.Name = "dgNomDep";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Sexe";
            this.dataGridViewTextBoxColumn24.DataSource = this.sexeBindingSource;
            this.dataGridViewTextBoxColumn24.DisplayMember = "Description";
            this.dataGridViewTextBoxColumn24.HeaderText = "Sexe";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn24.ValueMember = "idSexe";
            // 
            // dgDateNaissanceDep
            // 
            this.dgDateNaissanceDep.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle10.Format = "d";
            this.dgDateNaissanceDep.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgDateNaissanceDep.HeaderText = "Date de naissance";
            this.dgDateNaissanceDep.Name = "dgDateNaissanceDep";
            this.dgDateNaissanceDep.ReadOnly = true;
            // 
            // dgNoCiviqueDep
            // 
            this.dgNoCiviqueDep.DataPropertyName = "NoCivique";
            this.dgNoCiviqueDep.HeaderText = "Numéro civique";
            this.dgNoCiviqueDep.MaxInputLength = 10;
            this.dgNoCiviqueDep.Name = "dgNoCiviqueDep";
            // 
            // dgRueDep
            // 
            this.dgRueDep.DataPropertyName = "Rue";
            this.dgRueDep.HeaderText = "Rue";
            this.dgRueDep.MaxInputLength = 30;
            this.dgRueDep.Name = "dgRueDep";
            // 
            // dgVilleDep
            // 
            this.dgVilleDep.DataPropertyName = "Ville";
            this.dgVilleDep.HeaderText = "Ville";
            this.dgVilleDep.MaxInputLength = 30;
            this.dgVilleDep.Name = "dgVilleDep";
            // 
            // dgProvinceDep
            // 
            this.dgProvinceDep.DataPropertyName = "IdProvince";
            this.dgProvinceDep.DataSource = this.provinceBindingSource;
            this.dgProvinceDep.DisplayMember = "Nom";
            this.dgProvinceDep.HeaderText = "Province";
            this.dgProvinceDep.Name = "dgProvinceDep";
            this.dgProvinceDep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProvinceDep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgProvinceDep.ValueMember = "Id";
            // 
            // dgCodePostalDep
            // 
            this.dgCodePostalDep.DataPropertyName = "CodePostal";
            this.dgCodePostalDep.HeaderText = "Code postal";
            this.dgCodePostalDep.MaxInputLength = 6;
            this.dgCodePostalDep.Name = "dgCodePostalDep";
            // 
            // dgTelephoneDep
            // 
            this.dgTelephoneDep.DataPropertyName = "Telephone";
            this.dgTelephoneDep.HeaderText = "Telephone";
            this.dgTelephoneDep.MaxInputLength = 10;
            this.dgTelephoneDep.Name = "dgTelephoneDep";
            // 
            // dgCellulaireDep
            // 
            this.dgCellulaireDep.DataPropertyName = "Cellulaire";
            this.dgCellulaireDep.HeaderText = "Cellulaire";
            this.dgCellulaireDep.MaxInputLength = 10;
            this.dgCellulaireDep.Name = "dgCellulaireDep";
            // 
            // dgCourrielDep
            // 
            this.dgCourrielDep.DataPropertyName = "Courriel";
            this.dgCourrielDep.HeaderText = "Courriel";
            this.dgCourrielDep.MaxInputLength = 50;
            this.dgCourrielDep.Name = "dgCourrielDep";
            // 
            // dgTypeAbonnementDep
            // 
            this.dgTypeAbonnementDep.DataPropertyName = "NoTypeAbonnement";
            this.dgTypeAbonnementDep.DataSource = this.typesAbonnementBindingSource;
            this.dgTypeAbonnementDep.DisplayMember = "Description";
            this.dgTypeAbonnementDep.HeaderText = "Type d\'abonnement";
            this.dgTypeAbonnementDep.Name = "dgTypeAbonnementDep";
            this.dgTypeAbonnementDep.ReadOnly = true;
            this.dgTypeAbonnementDep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTypeAbonnementDep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTypeAbonnementDep.ValueMember = "No";
            // 
            // dgRemarque
            // 
            this.dgRemarque.DataPropertyName = "Remarque";
            this.dgRemarque.HeaderText = "Remarque";
            this.dgRemarque.MaxInputLength = 50;
            this.dgRemarque.Name = "dgRemarque";
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
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.dgDateAbonnement.DefaultCellStyle = dataGridViewCellStyle11;
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
            // dgDateNaissance
            // 
            this.dgDateNaissance.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.dgDateNaissance.DefaultCellStyle = dataGridViewCellStyle12;
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
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn16.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn16.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
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
            // frmMAJAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 539);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgAbonnementDependant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAbonnementPrincipal);
            this.Name = "frmMAJAbonne";
            this.Text = "Mise à jour des abonnés";
            this.Load += new System.EventHandler(this.frmMAJAbonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnementDependant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.DataGridView dgAbonnementPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgAbonnementDependant;
        private System.Windows.Forms.BindingSource abonnementBindingSource1;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIDDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateAbonnementDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenomDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomDep;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateNaissanceDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNoCiviqueDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRueDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVilleDep;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgProvinceDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodePostalDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelephoneDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCellulaireDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCourrielDep;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTypeAbonnementDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarque;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnRetour;
    }
}