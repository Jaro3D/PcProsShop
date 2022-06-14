namespace PcProsShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeButton = new PcProsShop.PrettyButton();
            this.header = new System.Windows.Forms.Panel();
            this.adminButton = new System.Windows.Forms.Panel();
            this.shoppingCartButton = new System.Windows.Forms.Panel();
            this.nameFirstChar = new System.Windows.Forms.Label();
            this.accountButton = new PcProsShop.PrettyButton();
            this.minimizeButton = new PcProsShop.PrettyButton();
            this.slogan = new System.Windows.Forms.Label();
            this.navbar = new System.Windows.Forms.Panel();
            this.rightArrow = new PcProsShop.PrettyButton();
            this.pageCountPanel = new System.Windows.Forms.Panel();
            this.pageCount = new System.Windows.Forms.Label();
            this.leftArrow = new PcProsShop.PrettyButton();
            this.ramButton = new PcProsShop.PrettyButton();
            this.cpuButton = new PcProsShop.PrettyButton();
            this.gpuButton = new PcProsShop.PrettyButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.itemBackground = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.navbar.SuspendLayout();
            this.pageCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.closeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.closeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeButton.BorderRadius = 12;
            this.closeButton.BorderSize = 0;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(765, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.TextColor = System.Drawing.Color.White;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.prettyButton1_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.BackgroundImage = global::PcProsShop.Properties.Resources.HeaderBackground;
            this.header.Controls.Add(this.adminButton);
            this.header.Controls.Add(this.shoppingCartButton);
            this.header.Controls.Add(this.nameFirstChar);
            this.header.Controls.Add(this.accountButton);
            this.header.Controls.Add(this.minimizeButton);
            this.header.Controls.Add(this.slogan);
            this.header.Controls.Add(this.closeButton);
            this.header.Location = new System.Drawing.Point(205, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(795, 100);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // adminButton
            // 
            this.adminButton.BackgroundImage = global::PcProsShop.Properties.Resources.AdminIcon;
            this.adminButton.Location = new System.Drawing.Point(528, 33);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(50, 50);
            this.adminButton.TabIndex = 7;
            this.adminButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adminButton_MouseDown);
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.BackgroundImage = global::PcProsShop.Properties.Resources.ShoppingCartIcon;
            this.shoppingCartButton.Location = new System.Drawing.Point(597, 33);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(50, 50);
            this.shoppingCartButton.TabIndex = 6;
            this.shoppingCartButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shoppingCartButton_MouseDown);
            // 
            // nameFirstChar
            // 
            this.nameFirstChar.AutoSize = true;
            this.nameFirstChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.nameFirstChar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameFirstChar.ForeColor = System.Drawing.Color.White;
            this.nameFirstChar.Location = new System.Drawing.Point(675, 42);
            this.nameFirstChar.Name = "nameFirstChar";
            this.nameFirstChar.Size = new System.Drawing.Size(25, 34);
            this.nameFirstChar.TabIndex = 5;
            this.nameFirstChar.Text = "J";
            this.nameFirstChar.Click += new System.EventHandler(this.nameFirstChar_Click);
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.accountButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.accountButton.BackgroundImage = global::PcProsShop.Properties.Resources.AccountIcon;
            this.accountButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.accountButton.BorderRadius = 25;
            this.accountButton.BorderSize = 0;
            this.accountButton.FlatAppearance.BorderSize = 0;
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountButton.ForeColor = System.Drawing.Color.White;
            this.accountButton.Location = new System.Drawing.Point(662, 33);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(50, 50);
            this.accountButton.TabIndex = 3;
            this.accountButton.TextColor = System.Drawing.Color.White;
            this.accountButton.UseVisualStyleBackColor = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(65)))));
            this.minimizeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(65)))));
            this.minimizeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minimizeButton.BorderRadius = 12;
            this.minimizeButton.BorderSize = 0;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(739, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 23);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TextColor = System.Drawing.Color.White;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Poppins", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.slogan.Location = new System.Drawing.Point(3, 29);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(452, 54);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "Technology for Innovators.";
            this.slogan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slogan_MouseDown);
            this.slogan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slogan_MouseMove);
            this.slogan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slogan_MouseUp);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.White;
            this.navbar.Controls.Add(this.rightArrow);
            this.navbar.Controls.Add(this.pageCountPanel);
            this.navbar.Controls.Add(this.leftArrow);
            this.navbar.Controls.Add(this.ramButton);
            this.navbar.Controls.Add(this.cpuButton);
            this.navbar.Controls.Add(this.gpuButton);
            this.navbar.Controls.Add(this.logo);
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(200, 700);
            this.navbar.TabIndex = 2;
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
            this.rightArrow.Location = new System.Drawing.Point(136, 630);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(40, 40);
            this.rightArrow.TabIndex = 6;
            this.rightArrow.TextColor = System.Drawing.Color.White;
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // pageCountPanel
            // 
            this.pageCountPanel.BackgroundImage = global::PcProsShop.Properties.Resources.PageCountBackground;
            this.pageCountPanel.Controls.Add(this.pageCount);
            this.pageCountPanel.Location = new System.Drawing.Point(68, 630);
            this.pageCountPanel.Name = "pageCountPanel";
            this.pageCountPanel.Size = new System.Drawing.Size(60, 40);
            this.pageCountPanel.TabIndex = 5;
            // 
            // pageCount
            // 
            this.pageCount.AutoSize = true;
            this.pageCount.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.pageCount.Location = new System.Drawing.Point(4, 6);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(52, 34);
            this.pageCount.TabIndex = 0;
            this.pageCount.Text = "1 / 3";
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
            this.leftArrow.Location = new System.Drawing.Point(20, 630);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(40, 40);
            this.leftArrow.TabIndex = 4;
            this.leftArrow.TextColor = System.Drawing.Color.White;
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // ramButton
            // 
            this.ramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ramButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ramButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ramButton.BorderRadius = 5;
            this.ramButton.BorderSize = 0;
            this.ramButton.FlatAppearance.BorderSize = 0;
            this.ramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ramButton.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.ramButton.Location = new System.Drawing.Point(15, 290);
            this.ramButton.Name = "ramButton";
            this.ramButton.Size = new System.Drawing.Size(170, 40);
            this.ramButton.TabIndex = 3;
            this.ramButton.Text = "RAM";
            this.ramButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.ramButton.UseVisualStyleBackColor = false;
            this.ramButton.Click += new System.EventHandler(this.ramButton_Click);
            // 
            // cpuButton
            // 
            this.cpuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cpuButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cpuButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cpuButton.BorderRadius = 5;
            this.cpuButton.BorderSize = 0;
            this.cpuButton.FlatAppearance.BorderSize = 0;
            this.cpuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpuButton.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.cpuButton.Location = new System.Drawing.Point(15, 235);
            this.cpuButton.Name = "cpuButton";
            this.cpuButton.Size = new System.Drawing.Size(170, 40);
            this.cpuButton.TabIndex = 2;
            this.cpuButton.Text = "Processor";
            this.cpuButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.cpuButton.UseVisualStyleBackColor = false;
            this.cpuButton.Click += new System.EventHandler(this.cpuButton_Click);
            // 
            // gpuButton
            // 
            this.gpuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.gpuButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.gpuButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gpuButton.BorderRadius = 5;
            this.gpuButton.BorderSize = 0;
            this.gpuButton.FlatAppearance.BorderSize = 0;
            this.gpuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpuButton.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuButton.ForeColor = System.Drawing.Color.White;
            this.gpuButton.Location = new System.Drawing.Point(15, 180);
            this.gpuButton.Name = "gpuButton";
            this.gpuButton.Size = new System.Drawing.Size(170, 40);
            this.gpuButton.TabIndex = 1;
            this.gpuButton.Text = "Graphics card";
            this.gpuButton.TextColor = System.Drawing.Color.White;
            this.gpuButton.UseVisualStyleBackColor = false;
            this.gpuButton.Click += new System.EventHandler(this.gpuButton_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(47, 29);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(102, 68);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // itemBackground
            // 
            this.itemBackground.BackColor = System.Drawing.Color.IndianRed;
            this.itemBackground.BackgroundImage = global::PcProsShop.Properties.Resources.ItemBackground;
            this.itemBackground.Location = new System.Drawing.Point(205, 105);
            this.itemBackground.Name = "itemBackground";
            this.itemBackground.Size = new System.Drawing.Size(795, 595);
            this.itemBackground.TabIndex = 3;
            this.itemBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.itemBackground_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PcProsShop.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.itemBackground);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.navbar.ResumeLayout(false);
            this.pageCountPanel.ResumeLayout(false);
            this.pageCountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PrettyButton closeButton;
        private Panel header;
        private Panel navbar;
        private Panel itemBackground;
        private PictureBox logo;
        private Label slogan;
        private PrettyButton minimizeButton;
        private PrettyButton gpuButton;
        private PrettyButton cpuButton;
        private PrettyButton ramButton;
        private PrettyButton accountButton;
        private Panel pageCountPanel;
        private PrettyButton leftArrow;
        private PrettyButton rightArrow;
        private Label pageCount;
        private Label nameFirstChar;
        private Panel shoppingCartButton;
        private Panel adminButton;
    }
}