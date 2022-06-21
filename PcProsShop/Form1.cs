using PcProsShop.UserControls;

namespace PcProsShop
{
    public enum Category
    {
        GPU,
        CPU,
        RAM
    }

    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point offset;
        public int tabIndex = 0;
        public int currentPage = 1;
        public int maxPage = 1;
        public Account account;
        public bool loggedIn = false;
        public bool isAdmin = false;
        public Label accChar;
        public Panel cartNotificationIcon;
        public List<CartItem> cartItems = new List<CartItem>();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitElements();
        }

        private void InitElements()
        {
            itemBackground.BackColor = Color.FromArgb(0, Color.Black);
            header.BackColor = Color.FromArgb(0, Color.Black);
            pageCountPanel.BackColor = Color.FromArgb(0, Color.Black);
            pageCount.BackColor = Color.FromArgb(0, Color.Black);
            cartNotfIcon.BackColor = Color.FromArgb(0, Color.Black);

            cartNotfIcon.Visible = false;
            nameFirstChar.Visible = false;

            cartNotificationIcon = cartNotfIcon;
            accChar = nameFirstChar;

            UC_Home ucHome = new UC_Home(tabIndex, this, currentPage);
            AddUserControl(ucHome);

            SwitchTab();
            UpdatePageCount();
            DeactivateAdminMode();
        }

        public void SwitchTab()
        {
            switch (tabIndex)
            {
                case 0:
                    EnableNavButtons();

                    ButtonSelect(gpuButton);
                    ButtonDeselect(cpuButton);
                    ButtonDeselect(ramButton);

                    UC_Home ucHome = new UC_Home(tabIndex, this, currentPage);
                    AddUserControl(ucHome);

                    break;

                case 1:
                    EnableNavButtons();

                    ButtonSelect(cpuButton);
                    ButtonDeselect(gpuButton);
                    ButtonDeselect(ramButton);

                    ucHome = new UC_Home(tabIndex, this, currentPage);
                    AddUserControl(ucHome);

                    break;

                case 2:
                    EnableNavButtons();

                    ButtonSelect(ramButton);
                    ButtonDeselect(cpuButton);
                    ButtonDeselect(gpuButton);

                    ucHome = new UC_Home(tabIndex, this, currentPage);
                    AddUserControl(ucHome);

                    break;

                case 3:
                    DisableNavButtons();

                    UC_ShoppingCart ucCart = new UC_ShoppingCart(this);
                    AddUserControl(ucCart);

                    break;

                case 4:
                    DisableNavButtons();

                    UC_Account ucAccount = new UC_Account(this, account);
                    AddUserControl(ucAccount);

                    break;

                case 5:
                    DisableNavButtons();

                    UC_Login ucLogin = new UC_Login(this);
                    AddUserControl(ucLogin);

                    break;

                case 6:
                    DisableNavButtons();

                    UC_Admin ucAdmin = new UC_Admin();
                    AddUserControl(ucAdmin);

                    break;

                default:
                    break;
            }
        }

        public void AddUserControl(UserControl userControl)
        { 
            userControl.Dock = DockStyle.Fill;
            itemBackground.Controls.Clear();
            itemBackground.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void EnableNavButtons()
        {
            gpuButton.Visible = true;
            cpuButton.Visible = true;
            ramButton.Visible = true;
            leftArrow.Visible = true;
            rightArrow.Visible = true;
            pageCountPanel.Visible = true;
        }
        public void DisableNavButtons()
        {
            gpuButton.Visible = false;
            cpuButton.Visible = false;
            ramButton.Visible = false;
            leftArrow.Visible = false;
            rightArrow.Visible = false;
            pageCountPanel.Visible = false;
        }
        public void EnablePageButtons()
        {
            leftArrow.Visible = true;
            rightArrow.Visible = true;
            pageCountPanel.Visible = true;
        }
        public void DisablePageButtons()
        {
            leftArrow.Visible = false;
            rightArrow.Visible = false;
            pageCountPanel.Visible = false;
        }

        public void ActivateAdminMode()
        { 
            isAdmin = true;
            adminButton.Visible = true;
        }

        public void DeactivateAdminMode()
        {
            isAdmin = false;
            adminButton.Visible = false;
        }

        private void ButtonSelect(PrettyButton button)
        {
            button.BackColor = ColorTranslator.FromHtml("#9f9f9f");
            button.TextColor = Color.White;
        }

        private void ButtonDeselect(PrettyButton button)
        {
            button.BackColor = ColorTranslator.FromHtml("#fafafc"); 
            button.TextColor = ColorTranslator.FromHtml("#bebdc4");
        }

        private void prettyButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the program?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y; 
            mouseDown = true;
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - offset.X, currentScreenPosition.Y - offset.Y);
            }
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void slogan_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void slogan_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - offset.X, currentScreenPosition.Y - offset.Y);
            }
        }

        private void slogan_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void gpuButton_Click(object sender, EventArgs e)
        {
            tabIndex = 0;
            SwitchTab();
        }

        private void cpuButton_Click(object sender, EventArgs e)
        {
            tabIndex = 1;
            currentPage = 1;
            UpdatePageCount();
            SwitchTab();
        }

        private void ramButton_Click(object sender, EventArgs e)
        {
            tabIndex = 2;
            currentPage = 1;
            UpdatePageCount();
            SwitchTab();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            tabIndex = 3;
            SwitchTab();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                tabIndex = 4;
            }
            else
            {
                tabIndex = 5;
            }
            
            SwitchTab();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            tabIndex = 0;
            SwitchTab();
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                UpdatePageCount();
            }
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                UpdatePageCount();
                UC_Home ucHome = new UC_Home(tabIndex, this, currentPage);
                AddUserControl(ucHome);
            }
        }

        public void UpdatePageCount()
        { 
            pageCount.Text = currentPage.ToString() + " / " + maxPage.ToString();
            UC_Home ucHome = new UC_Home(tabIndex, this, currentPage);
            AddUserControl(ucHome);
        }

        private void nameFirstChar_Click(object sender, EventArgs e)
        {
            tabIndex = 4;
            SwitchTab();
        }

        private void itemBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shoppingCartButton_MouseDown(object sender, MouseEventArgs e)
        {
            tabIndex = 3;
            SwitchTab();
        }

        private void adminButton_MouseDown(object sender, MouseEventArgs e)
        {
            tabIndex = 6;
            SwitchTab();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (loggedIn) 
            { 
                tabIndex = 4; 
            } 
            else 
            { 
                tabIndex = 5; 
            }

            SwitchTab();
        }
    }
}