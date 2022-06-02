namespace PcProsShop.UserControls
{
    partial class UC_Home
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
            this.item1 = new System.Windows.Forms.Panel();
            this.item4 = new System.Windows.Forms.Panel();
            this.item5 = new System.Windows.Forms.Panel();
            this.item2 = new System.Windows.Forms.Panel();
            this.item3 = new System.Windows.Forms.Panel();
            this.item6 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // item1
            // 
            this.item1.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackgroundBlue;
            this.item1.Location = new System.Drawing.Point(10, 10);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(250, 280);
            this.item1.TabIndex = 0;
            // 
            // item4
            // 
            this.item4.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackgroundGreen;
            this.item4.Location = new System.Drawing.Point(10, 305);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(250, 280);
            this.item4.TabIndex = 1;
            // 
            // item5
            // 
            this.item5.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackgroundGreen;
            this.item5.Location = new System.Drawing.Point(272, 305);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(250, 280);
            this.item5.TabIndex = 3;
            this.item5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // item2
            // 
            this.item2.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackgroundBlue;
            this.item2.Location = new System.Drawing.Point(272, 10);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(250, 280);
            this.item2.TabIndex = 2;
            // 
            // item3
            // 
            this.item3.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackgroundBlue;
            this.item3.Location = new System.Drawing.Point(534, 10);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(250, 280);
            this.item3.TabIndex = 4;
            // 
            // item6
            // 
            this.item6.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackgroundGreen;
            this.item6.Location = new System.Drawing.Point(534, 305);
            this.item6.Name = "item6";
            this.item6.Size = new System.Drawing.Size(250, 280);
            this.item6.TabIndex = 5;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.item6);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(795, 595);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel item1;
        private Panel item4;
        private Panel item5;
        private Panel item2;
        private Panel item3;
        private Panel item6;
    }
}
