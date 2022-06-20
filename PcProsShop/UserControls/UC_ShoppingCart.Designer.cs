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
            this.SuspendLayout();
            // 
            // cartItemList
            // 
            this.cartItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.priceColumt,
            this.amountColumn});
            this.cartItemList.Location = new System.Drawing.Point(15, 15);
            this.cartItemList.Name = "cartItemList";
            this.cartItemList.Size = new System.Drawing.Size(395, 565);
            this.cartItemList.TabIndex = 0;
            this.cartItemList.UseCompatibleStateImageBehavior = false;
            this.cartItemList.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 250;
            // 
            // priceColumt
            // 
            this.priceColumt.Text = "Price";
            this.priceColumt.Width = 80;
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Amount";
            // 
            // UC_ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cartItemList);
            this.Name = "UC_ShoppingCart";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_ShoppingCart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView cartItemList;
        private ColumnHeader nameColumn;
        private ColumnHeader priceColumt;
        private ColumnHeader amountColumn;
    }
}
