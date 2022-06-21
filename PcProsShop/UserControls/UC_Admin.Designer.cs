namespace PcProsShop.UserControls
{
    partial class UC_Admin
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
            this.editPanel = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoInput = new System.Windows.Forms.TextBox();
            this.pageCountPanel = new System.Windows.Forms.Panel();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.updateButton = new PcProsShop.PrettyButton();
            this.rightArrow = new PcProsShop.PrettyButton();
            this.leftArrow = new PcProsShop.PrettyButton();
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.priceColumt = new System.Windows.Forms.ColumnHeader();
            this.amountColumn = new System.Windows.Forms.ColumnHeader();
            this.editPanel.SuspendLayout();
            this.pageCountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.priceLabel);
            this.editPanel.Controls.Add(this.priceInput);
            this.editPanel.Controls.Add(this.infoLabel);
            this.editPanel.Controls.Add(this.infoInput);
            this.editPanel.Controls.Add(this.pageCountPanel);
            this.editPanel.Controls.Add(this.nameLabel);
            this.editPanel.Controls.Add(this.updateButton);
            this.editPanel.Controls.Add(this.rightArrow);
            this.editPanel.Controls.Add(this.leftArrow);
            this.editPanel.Location = new System.Drawing.Point(448, 48);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(344, 521);
            this.editPanel.TabIndex = 17;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(19, 73);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 37);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Price";
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceInput.Location = new System.Drawing.Point(26, 113);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(291, 48);
            this.priceInput.TabIndex = 16;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(19, 175);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(55, 37);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Info";
            // 
            // infoInput
            // 
            this.infoInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoInput.Location = new System.Drawing.Point(26, 214);
            this.infoInput.Name = "infoInput";
            this.infoInput.Size = new System.Drawing.Size(291, 31);
            this.infoInput.TabIndex = 14;
            // 
            // pageCountPanel
            // 
            this.pageCountPanel.BackgroundImage = global::PcProsShop.Properties.Resources.PageCountBackground;
            this.pageCountPanel.Controls.Add(this.itemAmountLabel);
            this.pageCountPanel.Location = new System.Drawing.Point(74, 272);
            this.pageCountPanel.Name = "pageCountPanel";
            this.pageCountPanel.Size = new System.Drawing.Size(60, 40);
            this.pageCountPanel.TabIndex = 11;
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
            this.itemAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(19, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(102, 48);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.updateButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.updateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateButton.BorderRadius = 5;
            this.updateButton.BorderSize = 0;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(26, 353);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 40);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.TextColor = System.Drawing.Color.White;
            this.updateButton.UseVisualStyleBackColor = false;
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
            this.rightArrow.Location = new System.Drawing.Point(142, 272);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(40, 40);
            this.rightArrow.TabIndex = 12;
            this.rightArrow.TextColor = System.Drawing.Color.White;
            this.rightArrow.UseVisualStyleBackColor = false;
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
            this.leftArrow.Location = new System.Drawing.Point(26, 272);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(40, 40);
            this.leftArrow.TabIndex = 10;
            this.leftArrow.TextColor = System.Drawing.Color.White;
            this.leftArrow.UseVisualStyleBackColor = false;
            // 
            // inventoryListView
            // 
            this.inventoryListView.AutoArrange = false;
            this.inventoryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.priceColumt,
            this.amountColumn});
            this.inventoryListView.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryListView.ForeColor = System.Drawing.Color.Black;
            this.inventoryListView.FullRowSelect = true;
            this.inventoryListView.Location = new System.Drawing.Point(15, 15);
            this.inventoryListView.MultiSelect = false;
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(395, 565);
            this.inventoryListView.TabIndex = 16;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
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
            // UC_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.inventoryListView);
            this.Name = "UC_Admin";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Admin_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.pageCountPanel.ResumeLayout(false);
            this.pageCountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel editPanel;
        private Panel pageCountPanel;
        private Label itemAmountLabel;
        private Label nameLabel;
        private PrettyButton updateButton;
        private PrettyButton rightArrow;
        private PrettyButton leftArrow;
        private ListView inventoryListView;
        private ColumnHeader nameColumn;
        private ColumnHeader priceColumt;
        private ColumnHeader amountColumn;
        private Label priceLabel;
        private TextBox priceInput;
        private Label infoLabel;
        private TextBox infoInput;
    }
}
