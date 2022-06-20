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
            this.editAccountButton = new PcProsShop.PrettyButton();
            this.saveAccountButton = new PcProsShop.PrettyButton();
            this.editPanel = new System.Windows.Forms.Panel();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.streetInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.editPanel.SuspendLayout();
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
            // editAccountButton
            // 
            this.editAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.editAccountButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.editAccountButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editAccountButton.BorderRadius = 8;
            this.editAccountButton.BorderSize = 0;
            this.editAccountButton.FlatAppearance.BorderSize = 0;
            this.editAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccountButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editAccountButton.ForeColor = System.Drawing.Color.White;
            this.editAccountButton.Location = new System.Drawing.Point(89, 508);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(100, 40);
            this.editAccountButton.TabIndex = 7;
            this.editAccountButton.Text = "Edit";
            this.editAccountButton.TextColor = System.Drawing.Color.White;
            this.editAccountButton.UseVisualStyleBackColor = false;
            this.editAccountButton.Click += new System.EventHandler(this.editAccountButton_Click);
            // 
            // saveAccountButton
            // 
            this.saveAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.saveAccountButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.saveAccountButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveAccountButton.BorderRadius = 8;
            this.saveAccountButton.BorderSize = 0;
            this.saveAccountButton.FlatAppearance.BorderSize = 0;
            this.saveAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAccountButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveAccountButton.ForeColor = System.Drawing.Color.White;
            this.saveAccountButton.Location = new System.Drawing.Point(212, 508);
            this.saveAccountButton.Name = "saveAccountButton";
            this.saveAccountButton.Size = new System.Drawing.Size(100, 40);
            this.saveAccountButton.TabIndex = 8;
            this.saveAccountButton.Text = "Save";
            this.saveAccountButton.TextColor = System.Drawing.Color.White;
            this.saveAccountButton.UseVisualStyleBackColor = false;
            this.saveAccountButton.Click += new System.EventHandler(this.saveAccountButton_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.zipInput);
            this.editPanel.Controls.Add(this.zipLabel);
            this.editPanel.Controls.Add(this.cityInput);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.streetInput);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.lastNameInput);
            this.editPanel.Controls.Add(this.lastNameLabel);
            this.editPanel.Controls.Add(this.firstNameInput);
            this.editPanel.Controls.Add(this.firstNameLabel);
            this.editPanel.Location = new System.Drawing.Point(68, 178);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(319, 309);
            this.editPanel.TabIndex = 9;
            // 
            // zipInput
            // 
            this.zipInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipInput.Location = new System.Drawing.Point(162, 205);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(130, 27);
            this.zipInput.TabIndex = 43;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipLabel.Location = new System.Drawing.Point(158, 181);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(81, 28);
            this.zipLabel.TabIndex = 42;
            this.zipLabel.Text = "Zip code";
            // 
            // cityInput
            // 
            this.cityInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityInput.Location = new System.Drawing.Point(19, 205);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(130, 27);
            this.cityInput.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "City";
            // 
            // streetInput
            // 
            this.streetInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetInput.Location = new System.Drawing.Point(19, 148);
            this.streetInput.Name = "streetInput";
            this.streetInput.Size = new System.Drawing.Size(273, 27);
            this.streetInput.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Street and number";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameInput.Location = new System.Drawing.Point(19, 92);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(273, 27);
            this.lastNameInput.TabIndex = 37;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(15, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 28);
            this.lastNameLabel.TabIndex = 36;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameInput.Location = new System.Drawing.Point(19, 37);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(273, 27);
            this.firstNameInput.TabIndex = 35;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(15, 13);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(95, 28);
            this.firstNameLabel.TabIndex = 34;
            this.firstNameLabel.Text = "First name";
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.saveAccountButton);
            this.Controls.Add(this.editAccountButton);
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
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
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
        private PrettyButton editAccountButton;
        private PrettyButton saveAccountButton;
        private Panel editPanel;
        private TextBox zipInput;
        private Label zipLabel;
        private TextBox cityInput;
        private Label label1;
        private TextBox streetInput;
        private Label label2;
        private TextBox lastNameInput;
        private Label lastNameLabel;
        private TextBox firstNameInput;
        private Label firstNameLabel;
    }
}
