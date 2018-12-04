namespace TP2
{
    partial class frmVisualisationRapport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rappDepEmploy = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rappDepAbonn = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rapDepAnnee = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rappPartieJoueeTerrain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.rapportPartiesJoueesAnnee = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RapportDepensesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepensesParAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PartiesJoueesTerrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PartieJoueesAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDepensesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepensesParAnneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartiesJoueesTerrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartieJoueesAnneeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1372, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rappDepEmploy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1364, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rapport dépenses par employé";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // rappDepEmploy
            // 
            this.rappDepEmploy.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RapportDepensesEmployeBindingSource;
            this.rappDepEmploy.LocalReport.DataSources.Add(reportDataSource1);
            this.rappDepEmploy.LocalReport.ReportEmbeddedResource = "TP2.Rapport de dépenses par employé.rdlc";
            this.rappDepEmploy.Location = new System.Drawing.Point(3, 3);
            this.rappDepEmploy.Name = "rappDepEmploy";
            this.rappDepEmploy.ServerReport.BearerToken = null;
            this.rappDepEmploy.Size = new System.Drawing.Size(1358, 394);
            this.rappDepEmploy.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rappDepAbonn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1364, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rapport depense par abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // rappDepAbonn
            // 
            this.rappDepAbonn.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.RapportDepensesEmployeBindingSource;
            this.rappDepAbonn.LocalReport.DataSources.Add(reportDataSource2);
            this.rappDepAbonn.LocalReport.ReportEmbeddedResource = "TP2.Rapport des dépenses par abonnement.rdlc";
            this.rappDepAbonn.Location = new System.Drawing.Point(3, 3);
            this.rappDepAbonn.Name = "rappDepAbonn";
            this.rappDepAbonn.ServerReport.BearerToken = null;
            this.rappDepAbonn.Size = new System.Drawing.Size(1358, 394);
            this.rappDepAbonn.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rapDepAnnee);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1364, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rapport dépenses par année";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // rapDepAnnee
            // 
            this.rapDepAnnee.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DepensesParAnneeBindingSource;
            this.rapDepAnnee.LocalReport.DataSources.Add(reportDataSource3);
            this.rapDepAnnee.LocalReport.ReportEmbeddedResource = "TP2.Rapport des dépenses par année.rdlc";
            this.rapDepAnnee.Location = new System.Drawing.Point(3, 3);
            this.rapDepAnnee.Name = "rapDepAnnee";
            this.rapDepAnnee.ServerReport.BearerToken = null;
            this.rapDepAnnee.Size = new System.Drawing.Size(1358, 394);
            this.rapDepAnnee.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rappPartieJoueeTerrain);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1364, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapport des parties jouées par terrain";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // rappPartieJoueeTerrain
            // 
            this.rappPartieJoueeTerrain.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.PartiesJoueesTerrainBindingSource;
            this.rappPartieJoueeTerrain.LocalReport.DataSources.Add(reportDataSource4);
            this.rappPartieJoueeTerrain.LocalReport.ReportEmbeddedResource = "TP2.Rapport des parties jouées par terrain.rdlc";
            this.rappPartieJoueeTerrain.Location = new System.Drawing.Point(3, 3);
            this.rappPartieJoueeTerrain.Name = "rappPartieJoueeTerrain";
            this.rappPartieJoueeTerrain.ServerReport.BearerToken = null;
            this.rappPartieJoueeTerrain.Size = new System.Drawing.Size(1358, 394);
            this.rappPartieJoueeTerrain.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1364, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Rapport des parties jouées par abonnement";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.PartiesJoueesTerrainBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP2.Rapport des parties jouées par abonnement.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1358, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.rapportPartiesJoueesAnnee);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1364, 400);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Rapport des parties jouées par année";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Enter += new System.EventHandler(this.tabPage6_Enter);
            // 
            // rapportPartiesJoueesAnnee
            // 
            this.rapportPartiesJoueesAnnee.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.PartieJoueesAnneeBindingSource;
            this.rapportPartiesJoueesAnnee.LocalReport.DataSources.Add(reportDataSource6);
            this.rapportPartiesJoueesAnnee.LocalReport.ReportEmbeddedResource = "TP2.Rapport des parties jouées par année.rdlc";
            this.rapportPartiesJoueesAnnee.Location = new System.Drawing.Point(3, 3);
            this.rapportPartiesJoueesAnnee.Name = "rapportPartiesJoueesAnnee";
            this.rapportPartiesJoueesAnnee.ServerReport.BearerToken = null;
            this.rapportPartiesJoueesAnnee.Size = new System.Drawing.Size(1358, 394);
            this.rapportPartiesJoueesAnnee.TabIndex = 0;
            // 
            // RapportDepensesEmployeBindingSource
            // 
            this.RapportDepensesEmployeBindingSource.DataSource = typeof(TP2.RapportDepensesEmploye);
            // 
            // DepensesParAnneeBindingSource
            // 
            this.DepensesParAnneeBindingSource.DataSource = typeof(TP2.DepensesParAnnee);
            // 
            // PartiesJoueesTerrainBindingSource
            // 
            this.PartiesJoueesTerrainBindingSource.DataSource = typeof(TP2.PartiesJoueesTerrain);
            // 
            // PartieJoueesAnneeBindingSource
            // 
            this.PartieJoueesAnneeBindingSource.DataSource = typeof(TP2.PartieJoueesAnnee);
            // 
            // frmVisualisationRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 444);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualisationRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualisation des rapports";
            this.Load += new System.EventHandler(this.frmVisualisationRapport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RapportDepensesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepensesParAnneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartiesJoueesTerrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartieJoueesAnneeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer rappDepEmploy;
        private Microsoft.Reporting.WinForms.ReportViewer rappPartieJoueeTerrain;
        private System.Windows.Forms.BindingSource PartiesJoueesTerrainBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer rapportPartiesJoueesAnnee;
        private System.Windows.Forms.BindingSource PartieJoueesAnneeBindingSource;
        private System.Windows.Forms.BindingSource RapportDepensesEmployeBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rappDepAbonn;
        private Microsoft.Reporting.WinForms.ReportViewer rapDepAnnee;
        private System.Windows.Forms.BindingSource DepensesParAnneeBindingSource;
    }
}