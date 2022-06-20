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
            this.itemPic = new System.Windows.Forms.Panel();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemPic
            // 
            this.itemPic.BackgroundImage = global::PcProsShop.Properties.Resources.Item_Ryzen5_5600X;
            this.itemPic.Location = new System.Drawing.Point(15, 92);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(220, 220);
            this.itemPic.TabIndex = 3;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemNameLabel.Location = new System.Drawing.Point(15, 19);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(151, 70);
            this.itemNameLabel.TabIndex = 4;
            this.itemNameLabel.Text = "Name";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemPic);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel itemPic;
        private Label itemNameLabel;
    }
}
