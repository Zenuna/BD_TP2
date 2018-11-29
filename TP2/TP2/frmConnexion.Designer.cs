namespace TP2
{
    partial class Connexion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoEmp = new System.Windows.Forms.TextBox();
            this.tbMdeP = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblErreurConnexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No employe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe : ";
            // 
            // tbNoEmp
            // 
            this.tbNoEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoEmp.Location = new System.Drawing.Point(174, 11);
            this.tbNoEmp.MaxLength = 3;
            this.tbNoEmp.Name = "tbNoEmp";
            this.tbNoEmp.Size = new System.Drawing.Size(207, 27);
            this.tbNoEmp.TabIndex = 2;
            this.tbNoEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMdeP
            // 
            this.tbMdeP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdeP.Location = new System.Drawing.Point(174, 50);
            this.tbMdeP.MaxLength = 50;
            this.tbMdeP.Name = "tbMdeP";
            this.tbMdeP.PasswordChar = '*';
            this.tbMdeP.Size = new System.Drawing.Size(207, 27);
            this.tbMdeP.TabIndex = 3;
            this.tbMdeP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(126, 136);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(141, 43);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblErreurConnexion
            // 
            this.lblErreurConnexion.AutoSize = true;
            this.lblErreurConnexion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurConnexion.ForeColor = System.Drawing.Color.Red;
            this.lblErreurConnexion.Location = new System.Drawing.Point(12, 95);
            this.lblErreurConnexion.Name = "lblErreurConnexion";
            this.lblErreurConnexion.Size = new System.Drawing.Size(128, 19);
            this.lblErreurConnexion.TabIndex = 5;
            this.lblErreurConnexion.Text = "Message d\'erreur";
            this.lblErreurConnexion.Visible = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 191);
            this.Controls.Add(this.lblErreurConnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbMdeP);
            this.Controls.Add(this.tbNoEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoEmp;
        private System.Windows.Forms.TextBox tbMdeP;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblErreurConnexion;
    }
}

