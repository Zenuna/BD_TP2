namespace TP2
{
    partial class frmGestionEmploye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTypeEmploye = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprEmp = new System.Windows.Forms.Button();
            this.dgEmploye = new System.Windows.Forms.DataGridView();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgNoEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMdeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProvince = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCellulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSalaireHoraire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeEmploye = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "TypesEmploye";
            this.dataGridViewComboBoxColumn1.HeaderText = "TypesEmploye";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 1963;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdProvince";
            this.dataGridViewTextBoxColumn10.DataSource = this.typesEmployeBindingSource;
            this.dataGridViewTextBoxColumn10.HeaderText = "IdProvince";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.Width = 116;
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(TP2.TypesEmploye);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CodePostal";
            this.dataGridViewTextBoxColumn11.HeaderText = "CodePostal";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 115;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn12.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 116;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Cellulaire";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cellulaire";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 115;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Courriel";
            this.dataGridViewTextBoxColumn14.HeaderText = "Courriel";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 116;
            // 
            // NoTypeEmploye
            // 
            this.NoTypeEmploye.DataPropertyName = "NoTypeEmploye";
            this.NoTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.NoTypeEmploye.DisplayMember = "Description";
            this.NoTypeEmploye.HeaderText = "NoTypeEmploye";
            this.NoTypeEmploye.Name = "NoTypeEmploye";
            this.NoTypeEmploye.ValueMember = "No";
            this.NoTypeEmploye.Width = 115;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SalaireHoraire";
            this.dataGridViewTextBoxColumn15.HeaderText = "SalaireHoraire";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 116;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn17.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 115;
            // 
            // msgErreur
            // 
            this.msgErreur.ContainerControl = this;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(12, 324);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(231, 41);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter un employé";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprEmp
            // 
            this.btnSupprEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprEmp.Location = new System.Drawing.Point(486, 324);
            this.btnSupprEmp.Name = "btnSupprEmp";
            this.btnSupprEmp.Size = new System.Drawing.Size(280, 41);
            this.btnSupprEmp.TabIndex = 3;
            this.btnSupprEmp.Text = "Supprimer les employés sélectionnés";
            this.btnSupprEmp.UseVisualStyleBackColor = true;
            this.btnSupprEmp.Click += new System.EventHandler(this.btnSupprEmp_Click);
            // 
            // dgEmploye
            // 
            this.dgEmploye.AllowUserToAddRows = false;
            this.dgEmploye.AllowUserToDeleteRows = false;
            this.dgEmploye.AutoGenerateColumns = false;
            this.dgEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNoEmploye,
            this.dgMdeP,
            this.dgNom,
            this.dgPrenom,
            this.dgSexe,
            this.dgAge,
            this.dgNoCivique,
            this.dgRue,
            this.dgVille,
            this.dgProvince,
            this.dgTelephone,
            this.dgCellulaire,
            this.dgCourriel,
            this.dgSalaireHoraire,
            this.dgTypeEmploye,
            this.dgRemarque});
            this.dgEmploye.DataSource = this.employeBindingSource;
            this.dgEmploye.Location = new System.Drawing.Point(12, 12);
            this.dgEmploye.Name = "dgEmploye";
            this.dgEmploye.Size = new System.Drawing.Size(1027, 306);
            this.dgEmploye.TabIndex = 0;
            this.dgEmploye.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgEmploye_CellValidating);
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(TP2.Sexe);
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(TP2.Province);
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataSource = typeof(TP2.Employe);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(249, 324);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(231, 41);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(772, 324);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(267, 41);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Retour au menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dgNoEmploye
            // 
            this.dgNoEmploye.DataPropertyName = "No";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dgNoEmploye.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgNoEmploye.HeaderText = "No employé";
            this.dgNoEmploye.MaxInputLength = 10;
            this.dgNoEmploye.Name = "dgNoEmploye";
            this.dgNoEmploye.ReadOnly = true;
            // 
            // dgMdeP
            // 
            this.dgMdeP.DataPropertyName = "MotDePasse";
            this.dgMdeP.HeaderText = "Mot de passe";
            this.dgMdeP.MaxInputLength = 50;
            this.dgMdeP.Name = "dgMdeP";
            this.dgMdeP.Width = 88;
            // 
            // dgNom
            // 
            this.dgNom.DataPropertyName = "Nom";
            this.dgNom.HeaderText = "Nom";
            this.dgNom.MaxInputLength = 50;
            this.dgNom.Name = "dgNom";
            this.dgNom.Width = 150;
            // 
            // dgPrenom
            // 
            this.dgPrenom.DataPropertyName = "Prenom";
            this.dgPrenom.HeaderText = "Prénom";
            this.dgPrenom.MaxInputLength = 50;
            this.dgPrenom.Name = "dgPrenom";
            this.dgPrenom.Width = 150;
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
            this.dgSexe.Width = 125;
            // 
            // dgAge
            // 
            this.dgAge.DataPropertyName = "Age";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dgAge.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAge.HeaderText = "Âge";
            this.dgAge.Name = "dgAge";
            this.dgAge.Width = 51;
            // 
            // dgNoCivique
            // 
            this.dgNoCivique.DataPropertyName = "NoCivique";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dgNoCivique.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNoCivique.HeaderText = "Numéro civique";
            this.dgNoCivique.MaxInputLength = 10;
            this.dgNoCivique.Name = "dgNoCivique";
            // 
            // dgRue
            // 
            this.dgRue.DataPropertyName = "Rue";
            this.dgRue.HeaderText = "Rue";
            this.dgRue.MaxInputLength = 50;
            this.dgRue.Name = "dgRue";
            // 
            // dgVille
            // 
            this.dgVille.DataPropertyName = "Ville";
            this.dgVille.HeaderText = "Ville";
            this.dgVille.MaxInputLength = 50;
            this.dgVille.Name = "dgVille";
            // 
            // dgProvince
            // 
            this.dgProvince.DataPropertyName = "IdProvince";
            this.dgProvince.DataSource = this.provinceBindingSource;
            this.dgProvince.DisplayMember = "Nom";
            this.dgProvince.HeaderText = "Province";
            this.dgProvince.Name = "dgProvince";
            this.dgProvince.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProvince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgProvince.ValueMember = "Id";
            this.dgProvince.Width = 175;
            // 
            // dgTelephone
            // 
            this.dgTelephone.DataPropertyName = "Telephone";
            dataGridViewCellStyle4.NullValue = null;
            this.dgTelephone.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgCourriel.Width = 150;
            // 
            // dgSalaireHoraire
            // 
            this.dgSalaireHoraire.DataPropertyName = "SalaireHoraire";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dgSalaireHoraire.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgSalaireHoraire.HeaderText = "Salaire horaire";
            this.dgSalaireHoraire.Name = "dgSalaireHoraire";
            // 
            // dgTypeEmploye
            // 
            this.dgTypeEmploye.DataPropertyName = "NoTypeEmploye";
            this.dgTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.dgTypeEmploye.DisplayMember = "Description";
            this.dgTypeEmploye.HeaderText = "Type d\'employé";
            this.dgTypeEmploye.Name = "dgTypeEmploye";
            this.dgTypeEmploye.ReadOnly = true;
            this.dgTypeEmploye.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTypeEmploye.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTypeEmploye.ValueMember = "No";
            this.dgTypeEmploye.Width = 200;
            // 
            // dgRemarque
            // 
            this.dgRemarque.DataPropertyName = "Remarque";
            this.dgRemarque.HeaderText = "Remarque";
            this.dgRemarque.MaxInputLength = 50;
            this.dgRemarque.Name = "dgRemarque";
            this.dgRemarque.Width = 200;
            // 
            // frmGestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1060, 377);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSupprEmp);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionEmploye";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.frmGestionEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource employeBindingSource;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewComboBoxColumn NoTypeEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.ErrorProvider msgErreur;
        private System.Windows.Forms.Button btnSupprEmp;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgEmploye;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNoEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMdeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenom;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNoCivique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVille;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCellulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCourriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSalaireHoraire;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTypeEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarque;
    }
}