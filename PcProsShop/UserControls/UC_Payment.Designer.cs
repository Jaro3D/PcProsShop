namespace PcProsShop.UserControls
{
    partial class UC_Payment
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
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.payAmountLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.prettyButton1 = new PcProsShop.PrettyButton();
            this.SuspendLayout();
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAmountLabel.Location = new System.Drawing.Point(45, 31);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(207, 48);
            this.totalAmountLabel.TabIndex = 1;
            this.totalAmountLabel.Text = "Total amount:";
            this.totalAmountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(45, 93);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(243, 48);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Delivery address";
            // 
            // payAmountLabel
            // 
            this.payAmountLabel.AutoSize = true;
            this.payAmountLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(218)))));
            this.payAmountLabel.Location = new System.Drawing.Point(247, 31);
            this.payAmountLabel.Name = "payAmountLabel";
            this.payAmountLabel.Size = new System.Drawing.Size(85, 48);
            this.payAmountLabel.TabIndex = 3;
            this.payAmountLabel.Text = "100€";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipCodeLabel.Location = new System.Drawing.Point(45, 289);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(106, 37);
            this.zipCodeLabel.TabIndex = 11;
            this.zipCodeLabel.Text = "Zip code";
            this.zipCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(45, 215);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(58, 37);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLabel.Location = new System.Drawing.Point(45, 252);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(79, 37);
            this.streetLabel.TabIndex = 9;
            this.streetLabel.Text = "Street";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(45, 178);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(74, 37);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Location = new System.Drawing.Point(45, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 37);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PayPal",
            "Klarna"});
            this.comboBox1.Location = new System.Drawing.Point(50, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 45);
            this.comboBox1.TabIndex = 12;
            // 
            // prettyButton1
            // 
            this.prettyButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.prettyButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.prettyButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.prettyButton1.BorderRadius = 5;
            this.prettyButton1.BorderSize = 0;
            this.prettyButton1.FlatAppearance.BorderSize = 0;
            this.prettyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prettyButton1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prettyButton1.ForeColor = System.Drawing.Color.White;
            this.prettyButton1.Location = new System.Drawing.Point(50, 507);
            this.prettyButton1.Name = "prettyButton1";
            this.prettyButton1.Size = new System.Drawing.Size(180, 40);
            this.prettyButton1.TabIndex = 16;
            this.prettyButton1.Text = "Confirm";
            this.prettyButton1.TextColor = System.Drawing.Color.White;
            this.prettyButton1.UseVisualStyleBackColor = false;
            // 
            // UC_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.prettyButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.payAmountLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Name = "UC_Payment";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalAmountLabel;
        private Label addressLabel;
        private Label payAmountLabel;
        private Label zipCodeLabel;
        private Label cityLabel;
        private Label streetLabel;
        private Label emailLabel;
        private Label nameLabel;
        private ComboBox comboBox1;
        private PrettyButton prettyButton1;
    }
}
