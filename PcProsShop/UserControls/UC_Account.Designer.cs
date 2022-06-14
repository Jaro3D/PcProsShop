namespace PcProsShop.UserControls
{
    partial class UC_Account
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameFirstChar = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Location = new System.Drawing.Point(74, 118);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(151, 70);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PcProsShop.Properties.Resources.AccountIconEmpty;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.nameFirstChar);
            this.panel1.Location = new System.Drawing.Point(89, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 2;
            // 
            // nameFirstChar
            // 
            this.nameFirstChar.AutoSize = true;
            this.nameFirstChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.nameFirstChar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameFirstChar.ForeColor = System.Drawing.Color.White;
            this.nameFirstChar.Location = new System.Drawing.Point(13, 9);
            this.nameFirstChar.Name = "nameFirstChar";
            this.nameFirstChar.Size = new System.Drawing.Size(25, 34);
            this.nameFirstChar.TabIndex = 6;
            this.nameFirstChar.Text = "J";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(79, 178);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(94, 48);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLabel.Location = new System.Drawing.Point(79, 274);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(100, 48);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(79, 226);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(73, 48);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipCodeLabel.Location = new System.Drawing.Point(79, 322);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(135, 48);
            this.zipCodeLabel.TabIndex = 6;
            this.zipCodeLabel.Text = "Zip code";
            this.zipCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameLabel);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Panel panel1;
        private Label nameFirstChar;
        private Label emailLabel;
        private Label streetLabel;
        private Label cityLabel;
        private Label zipCodeLabel;
    }
}
