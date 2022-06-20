namespace PcProsShop.UserControls
{
    partial class UC_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            this.itemPic = new System.Windows.Forms.Panel();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.leftArrow = new PcProsShop.PrettyButton();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            this.rightArrow = new PcProsShop.PrettyButton();
            this.pageCountPanel = new System.Windows.Forms.Panel();
            this.addButton = new PcProsShop.PrettyButton();
            this.stockLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.fillingTextBox = new System.Windows.Forms.RichTextBox();
            this.pageCountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPic
            // 
            this.itemPic.BackgroundImage = global::PcProsShop.Properties.Resources.Item_Ryzen5_5600X;
            this.itemPic.Location = new System.Drawing.Point(29, 30);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(220, 220);
            this.itemPic.TabIndex = 3;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemNameLabel.Location = new System.Drawing.Point(255, 30);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(151, 70);
            this.itemNameLabel.TabIndex = 4;
            this.itemNameLabel.Text = "Name";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoLabel.Location = new System.Drawing.Point(266, 177);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(55, 37);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.leftArrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.leftArrow.BackgroundImage = global::PcProsShop.Properties.Resources.LeftArrow;
            this.leftArrow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.leftArrow.BorderRadius = 5;
            this.leftArrow.BorderSize = 0;
            this.leftArrow.FlatAppearance.BorderSize = 0;
            this.leftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftArrow.ForeColor = System.Drawing.Color.White;
            this.leftArrow.Location = new System.Drawing.Point(611, 100);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(40, 40);
            this.leftArrow.TabIndex = 7;
            this.leftArrow.TextColor = System.Drawing.Color.White;
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // itemAmountLabel
            // 
            this.itemAmountLabel.AutoSize = true;
            this.itemAmountLabel.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.itemAmountLabel.Location = new System.Drawing.Point(19, 6);
            this.itemAmountLabel.Name = "itemAmountLabel";
            this.itemAmountLabel.Size = new System.Drawing.Size(22, 34);
            this.itemAmountLabel.TabIndex = 0;
            this.itemAmountLabel.Text = "1";
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.rightArrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.rightArrow.BackgroundImage = global::PcProsShop.Properties.Resources.RightArrow;
            this.rightArrow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rightArrow.BorderRadius = 5;
            this.rightArrow.BorderSize = 0;
            this.rightArrow.FlatAppearance.BorderSize = 0;
            this.rightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightArrow.ForeColor = System.Drawing.Color.White;
            this.rightArrow.Location = new System.Drawing.Point(727, 100);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(40, 40);
            this.rightArrow.TabIndex = 9;
            this.rightArrow.TextColor = System.Drawing.Color.White;
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // pageCountPanel
            // 
            this.pageCountPanel.BackgroundImage = global::PcProsShop.Properties.Resources.PageCountBackground;
            this.pageCountPanel.Controls.Add(this.itemAmountLabel);
            this.pageCountPanel.Location = new System.Drawing.Point(659, 100);
            this.pageCountPanel.Name = "pageCountPanel";
            this.pageCountPanel.Size = new System.Drawing.Size(60, 40);
            this.pageCountPanel.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.addButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(86)))), ((int)(((byte)(132)))));
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 5;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(611, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 39);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add to cart";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            this.stockLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockLabel.Location = new System.Drawing.Point(266, 100);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(76, 37);
            this.stockLabel.TabIndex = 11;
            this.stockLabel.Text = "Stock";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brandLabel.Location = new System.Drawing.Point(266, 140);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(79, 37);
            this.brandLabel.TabIndex = 12;
            this.brandLabel.Text = "Brand";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceLabel.Location = new System.Drawing.Point(611, 39);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 56);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "100€";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillingTextBox
            // 
            this.fillingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fillingTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fillingTextBox.Location = new System.Drawing.Point(29, 275);
            this.fillingTextBox.Name = "fillingTextBox";
            this.fillingTextBox.Size = new System.Drawing.Size(738, 295);
            this.fillingTextBox.TabIndex = 14;
            this.fillingTextBox.Text = resources.GetString("fillingTextBox.Text");
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fillingTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.pageCountPanel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemPic);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Item_Load);
            this.pageCountPanel.ResumeLayout(false);
            this.pageCountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel itemPic;
        private Label itemNameLabel;
        private Label infoLabel;
        private PrettyButton leftArrow;
        private Label itemAmountLabel;
        private PrettyButton rightArrow;
        private Panel pageCountPanel;
        private PrettyButton addButton;
        private Label stockLabel;
        private Label brandLabel;
        private Label priceLabel;
        private RichTextBox fillingTextBox;
    }
}
