namespace PcProsShop.UserControls
{
    partial class UC_Login
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
            this.header = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new PcProsShop.PrettyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(254, 100);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(100, 48);
            this.header.TabIndex = 2;
            this.header.Text = "LOGIN";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(257, 172);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 34);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(262, 209);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(271, 36);
            this.emailInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(262, 296);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(271, 36);
            this.passwordInput.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(257, 259);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 34);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.loginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.loginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginButton.BorderRadius = 8;
            this.loginButton.BorderSize = 0;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(262, 359);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(271, 40);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "LOGIN";
            this.loginButton.TextColor = System.Drawing.Color.White;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PcProsShop.Properties.Resources.LoginDevider;
            this.panel1.Location = new System.Drawing.Point(261, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 29);
            this.panel1.TabIndex = 8;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(284, 466);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(158, 28);
            this.questionLabel.TabIndex = 9;
            this.questionLabel.Text = "Need an account?";
            // 
            // signupButton
            // 
            this.signupButton.AutoSize = true;
            this.signupButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.signupButton.Location = new System.Drawing.Point(438, 466);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(72, 28);
            this.signupButton.TabIndex = 10;
            this.signupButton.Text = "SIGN UP";
            this.signupButton.Click += new System.EventHandler(this.label1_Click);
            this.signupButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signupButton_MouseDown);
            this.signupButton.MouseEnter += new System.EventHandler(this.signupButton_MouseEnter);
            this.signupButton.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.signupButton.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.header);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label header;
        private Label emailLabel;
        private TextBox emailInput;
        private TextBox passwordInput;
        private Label passwordLabel;
        private PrettyButton loginButton;
        private Panel panel1;
        private Label questionLabel;
        private Label signupButton;
    }
}
