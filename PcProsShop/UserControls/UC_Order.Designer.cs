namespace PcProsShop.UserControls
{
    partial class UC_Order
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.preStatusLabel = new System.Windows.Forms.Label();
            this.cancelButton = new PcProsShop.PrettyButton();
            this.orderNameLabel = new System.Windows.Forms.Label();
            this.orderPrice = new System.Windows.Forms.Label();
            this.orderViewList = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.priceColumt = new System.Windows.Forms.ColumnHeader();
            this.amountColumn = new System.Windows.Forms.ColumnHeader();
            this.updateStatusButton = new PcProsShop.PrettyButton();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.updateStatusButton);
            this.editPanel.Controls.Add(this.statusLabel);
            this.editPanel.Controls.Add(this.preStatusLabel);
            this.editPanel.Controls.Add(this.cancelButton);
            this.editPanel.Controls.Add(this.orderNameLabel);
            this.editPanel.Controls.Add(this.orderPrice);
            this.editPanel.Location = new System.Drawing.Point(446, 47);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(283, 521);
            this.editPanel.TabIndex = 17;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(65)))));
            this.statusLabel.Location = new System.Drawing.Point(126, 53);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(107, 48);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status";
            // 
            // preStatusLabel
            // 
            this.preStatusLabel.AutoSize = true;
            this.preStatusLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preStatusLabel.Location = new System.Drawing.Point(18, 53);
            this.preStatusLabel.Name = "preStatusLabel";
            this.preStatusLabel.Size = new System.Drawing.Size(111, 48);
            this.preStatusLabel.TabIndex = 15;
            this.preStatusLabel.Text = "Status:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.BackgroundColor = System.Drawing.Color.Red;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 5;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(18, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // orderNameLabel
            // 
            this.orderNameLabel.AutoSize = true;
            this.orderNameLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderNameLabel.Location = new System.Drawing.Point(18, 5);
            this.orderNameLabel.Name = "orderNameLabel";
            this.orderNameLabel.Size = new System.Drawing.Size(102, 48);
            this.orderNameLabel.TabIndex = 1;
            this.orderNameLabel.Text = "Name";
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSize = true;
            this.orderPrice.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(218)))));
            this.orderPrice.Location = new System.Drawing.Point(18, 102);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(70, 37);
            this.orderPrice.TabIndex = 2;
            this.orderPrice.Text = "100€";
            // 
            // orderViewList
            // 
            this.orderViewList.AutoArrange = false;
            this.orderViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.priceColumt,
            this.amountColumn});
            this.orderViewList.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderViewList.ForeColor = System.Drawing.Color.Black;
            this.orderViewList.FullRowSelect = true;
            this.orderViewList.Location = new System.Drawing.Point(15, 15);
            this.orderViewList.MultiSelect = false;
            this.orderViewList.Name = "orderViewList";
            this.orderViewList.Size = new System.Drawing.Size(395, 565);
            this.orderViewList.TabIndex = 16;
            this.orderViewList.UseCompatibleStateImageBehavior = false;
            this.orderViewList.View = System.Windows.Forms.View.Details;
            this.orderViewList.SelectedIndexChanged += new System.EventHandler(this.orderViewList_SelectedIndexChanged);
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
            // updateStatusButton
            // 
            this.updateStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.updateStatusButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.updateStatusButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateStatusButton.BorderRadius = 5;
            this.updateStatusButton.BorderSize = 0;
            this.updateStatusButton.FlatAppearance.BorderSize = 0;
            this.updateStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStatusButton.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateStatusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.updateStatusButton.Location = new System.Drawing.Point(18, 466);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(170, 40);
            this.updateStatusButton.TabIndex = 17;
            this.updateStatusButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.updateStatusButton.UseVisualStyleBackColor = false;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.orderViewList);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Order_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel editPanel;
        private Label statusLabel;
        private Label preStatusLabel;
        private PrettyButton cancelButton;
        private Label orderNameLabel;
        private Label orderPrice;
        private ListView orderViewList;
        private ColumnHeader nameColumn;
        private ColumnHeader priceColumt;
        private ColumnHeader amountColumn;
        private PrettyButton updateStatusButton;
    }
}
