namespace PcProsShop.UserControls
{
    partial class UC_Registration
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
            this.signupButton = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.signupButon = new PcProsShop.PrettyButton();
            this.confPasswordInput = new System.Windows.Forms.TextBox();
            this.confPasswordLabel = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.streetInput = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.AutoSize = true;
            this.signupButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.signupButton.Location = new System.Drawing.Point(426, 553);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(72, 28);
            this.signupButton.TabIndex = 18;
            this.signupButton.Text = "SIGN UP";
            this.signupButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signupButton_MouseDown);
            this.signupButton.MouseEnter += new System.EventHandler(this.signupButton_MouseEnter);
            this.signupButton.MouseLeave += new System.EventHandler(this.signupButton_MouseLeave);
            this.signupButton.MouseHover += new System.EventHandler(this.signupButton_MouseHover);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(296, 553);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(135, 28);
            this.questionLabel.TabIndex = 17;
            this.questionLabel.Text = "Already a user?";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PcProsShop.Properties.Resources.LoginDevider;
            this.panel1.Location = new System.Drawing.Point(264, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 29);
            this.panel1.TabIndex = 16;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(267, 169);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(271, 27);
            this.passwordInput.TabIndex = 15;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(262, 139);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 34);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(267, 109);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(271, 27);
            this.emailInput.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(262, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 34);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(262, 15);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(124, 48);
            this.header.TabIndex = 11;
            this.header.Text = "SIGN UP";
            // 
            // signupButon
            // 
            this.signupButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.signupButon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.signupButon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.signupButon.BorderRadius = 8;
            this.signupButon.BorderSize = 0;
            this.signupButon.FlatAppearance.BorderSize = 0;
            this.signupButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButon.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signupButon.ForeColor = System.Drawing.Color.White;
            this.signupButon.Location = new System.Drawing.Point(262, 458);
            this.signupButon.Name = "signupButon";
            this.signupButon.Size = new System.Drawing.Size(271, 40);
            this.signupButon.TabIndex = 19;
            this.signupButon.Text = "SIGN UP";
            this.signupButon.TextColor = System.Drawing.Color.White;
            this.signupButon.UseVisualStyleBackColor = false;
            // 
            // confPasswordInput
            // 
            this.confPasswordInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confPasswordInput.Location = new System.Drawing.Point(267, 231);
            this.confPasswordInput.Name = "confPasswordInput";
            this.confPasswordInput.Size = new System.Drawing.Size(271, 27);
            this.confPasswordInput.TabIndex = 21;
            // 
            // confPasswordLabel
            // 
            this.confPasswordLabel.AutoSize = true;
            this.confPasswordLabel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confPasswordLabel.Location = new System.Drawing.Point(262, 200);
            this.confPasswordLabel.Name = "confPasswordLabel";
            this.confPasswordLabel.Size = new System.Drawing.Size(191, 34);
            this.confPasswordLabel.TabIndex = 20;
            this.confPasswordLabel.Text = "Confirm password";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameInput.Location = new System.Drawing.Point(264, 297);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(130, 27);
            this.firstNameInput.TabIndex = 23;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(260, 270);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(95, 28);
            this.firstNameLabel.TabIndex = 22;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameInput.Location = new System.Drawing.Point(407, 297);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(130, 27);
            this.lastNameInput.TabIndex = 25;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(403, 270);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 28);
            this.lastNameLabel.TabIndex = 24;
            this.lastNameLabel.Text = "Last name";
            // 
            // streetInput
            // 
            this.streetInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetInput.Location = new System.Drawing.Point(264, 354);
            this.streetInput.Name = "streetInput";
            this.streetInput.Size = new System.Drawing.Size(269, 27);
            this.streetInput.TabIndex = 27;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLabel.Location = new System.Drawing.Point(260, 327);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(162, 28);
            this.streetLabel.TabIndex = 26;
            this.streetLabel.Text = "Street and number";
            // 
            // zipInput
            // 
            this.zipInput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipInput.Location = new System.Drawing.Point(407, 411);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(130, 27);
            this.zipInput.TabIndex = 33;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipLabel.Location = new System.Drawing.Point(403, 384);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(81, 28);
            this.zipLabel.TabIndex = 32;
            this.zipLabel.Text = "Zip code";
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(264, 411);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(130, 27);
            this.city.TabIndex = 31;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(260, 384);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 28);
            this.cityLabel.TabIndex = 30;
            this.cityLabel.Text = "City";
            // 
            // UC_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.zipInput);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.city);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetInput);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.confPasswordInput);
            this.Controls.Add(this.confPasswordLabel);
            this.Controls.Add(this.signupButon);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.header);
            this.Name = "UC_Registration";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label signupButton;
        private Label questionLabel;
        private Panel panel1;
        private TextBox passwordInput;
        private Label passwordLabel;
        private TextBox emailInput;
        private Label emailLabel;
        private Label header;
        private PrettyButton signupButon;
        private TextBox confPasswordInput;
        private Label confPasswordLabel;
        private TextBox firstNameInput;
        private Label firstNameLabel;
        private TextBox lastNameInput;
        private Label lastNameLabel;
        private TextBox streetInput;
        private Label streetLabel;
        private TextBox zipInput;
        private Label zipLabel;
        private TextBox city;
        private Label cityLabel;
    }
}
