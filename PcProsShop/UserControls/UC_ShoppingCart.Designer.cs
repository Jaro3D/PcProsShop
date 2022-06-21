namespace PcProsShop.UserControls
{
    partial class UC_ShoppingCart
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
            this.cartItemList = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.priceColumt = new System.Windows.Forms.ColumnHeader();
            this.amountColumn = new System.Windows.Forms.ColumnHeader();
            this.itemName = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.rightArrow = new PcProsShop.PrettyButton();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            this.leftArrow = new PcProsShop.PrettyButton();
            this.pageCountPanel = new System.Windows.Forms.Panel();
            this.editButton = new PcProsShop.PrettyButton();
            this.deleteButton = new PcProsShop.PrettyButton();
            this.editPanel = new System.Windows.Forms.Panel();
            this.prettyButton1 = new PcProsShop.PrettyButton();
            this.pageCountPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartItemList
            // 
            this.cartItemList.AutoArrange = false;
            this.cartItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.priceColumt,
            this.amountColumn});
            this.cartItemList.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartItemList.ForeColor = System.Drawing.Color.Black;
            this.cartItemList.FullRowSelect = true;
            this.cartItemList.Location = new System.Drawing.Point(15, 15);
            this.cartItemList.MultiSelect = false;
            this.cartItemList.Name = "cartItemList";
            this.cartItemList.Size = new System.Drawing.Size(395, 565);
            this.cartItemList.TabIndex = 0;
            this.cartItemList.UseCompatibleStateImageBehavior = false;
            this.cartItemList.View = System.Windows.Forms.View.Details;
            this.cartItemList.SelectedIndexChanged += new System.EventHandler(this.cartItemList_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 225;
            // 
            // priceColumt
            // 
            this.priceColumt.Text = "Price";
            this.priceColumt.Width = 80;
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Amount";
            this.amountColumn.Width = 90;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemName.Location = new System.Drawing.Point(18, 5);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(102, 48);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Name";
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(218)))));
            this.itemPrice.Location = new System.Drawing.Point(18, 53);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(70, 37);
            this.itemPrice.TabIndex = 2;
            this.itemPrice.Text = "100€";
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
            this.rightArrow.Location = new System.Drawing.Point(143, 110);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(40, 40);
            this.rightArrow.TabIndex = 12;
            this.rightArrow.TextColor = System.Drawing.Color.White;
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
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
            this.leftArrow.Location = new System.Drawing.Point(27, 110);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(40, 40);
            this.leftArrow.TabIndex = 10;
            this.leftArrow.TextColor = System.Drawing.Color.White;
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // pageCountPanel
            // 
            this.pageCountPanel.BackgroundImage = global::PcProsShop.Properties.Resources.PageCountBackground;
            this.pageCountPanel.Controls.Add(this.itemAmountLabel);
            this.pageCountPanel.Location = new System.Drawing.Point(75, 110);
            this.pageCountPanel.Name = "pageCountPanel";
            this.pageCountPanel.Size = new System.Drawing.Size(60, 40);
            this.pageCountPanel.TabIndex = 11;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.editButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 5;
            this.editButton.BorderSize = 0;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(25, 191);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 40);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.BackgroundColor = System.Drawing.Color.Red;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(143, 191);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.prettyButton1);
            this.editPanel.Controls.Add(this.pageCountPanel);
            this.editPanel.Controls.Add(this.deleteButton);
            this.editPanel.Controls.Add(this.itemName);
            this.editPanel.Controls.Add(this.editButton);
            this.editPanel.Controls.Add(this.itemPrice);
            this.editPanel.Controls.Add(this.rightArrow);
            this.editPanel.Controls.Add(this.leftArrow);
            this.editPanel.Location = new System.Drawing.Point(448, 48);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(283, 521);
            this.editPanel.TabIndex = 15;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editPanel_Paint);
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
            this.prettyButton1.Location = new System.Drawing.Point(25, 254);
            this.prettyButton1.Name = "prettyButton1";
            this.prettyButton1.Size = new System.Drawing.Size(218, 40);
            this.prettyButton1.TabIndex = 15;
            this.prettyButton1.Text = "Checkout";
            this.prettyButton1.TextColor = System.Drawing.Color.White;
            this.prettyButton1.UseVisualStyleBackColor = false;
            this.prettyButton1.Click += new System.EventHandler(this.prettyButton1_Click);
            // 
            // UC_ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.cartItemList);
            this.Name = "UC_ShoppingCart";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_ShoppingCart_Load);
            this.pageCountPanel.ResumeLayout(false);
            this.pageCountPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView cartItemList;
        private ColumnHeader nameColumn;
        private ColumnHeader priceColumt;
        private ColumnHeader amountColumn;
        private Label itemName;
        private Label itemPrice;
        private PrettyButton rightArrow;
        private Label itemAmountLabel;
        private PrettyButton leftArrow;
        private Panel pageCountPanel;
        private PrettyButton editButton;
        private PrettyButton deleteButton;
        private Panel editPanel;
        private PrettyButton prettyButton1;
    }
}
