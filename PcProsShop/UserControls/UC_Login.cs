using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcProsShop.UserControls
{
    public partial class UC_Login : UserControl
    {
        Form1 parentForm;

        public UC_Login(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UC_Registration ucRegistration = new UC_Registration(parentForm);
            parentForm.AddUserControl(ucRegistration);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(100, 238, 86, 132);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.Black;
        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(100, 238, 86, 132);
        }

        private void signupButton_MouseDown(object sender, MouseEventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(100, 0, 0, 255);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emailInput.Text != "" && passwordInput.Text != "")
            {
                try
                {
                    Account accs = Database.LoadAccount(emailInput.Text.ToLower(), passwordInput.Text);
                    char accName = accs.Fname[0];
                    parentForm.account = accs;
                    parentForm.loggedIn = true;
                    parentForm.accChar.Visible = true;
                    parentForm.accChar.Text = accName.ToString();
                    parentForm.accountIcon.BackgroundImage = Properties.Resources.AccountIconEmpty;

                    if (accs.IsAdmin == 1)
                    {
                        parentForm.ActivateAdminMode();
                    }

                    parentForm.tabIndex = 0;
                    parentForm.SwitchTab();

                }
                catch (Exception)
                {
                    MessageBox.Show("Email or password incorrect");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out");
            }
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
