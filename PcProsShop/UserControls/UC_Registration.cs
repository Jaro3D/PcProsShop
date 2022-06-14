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
    public partial class UC_Registration : UserControl
    {
        Form1 parentForm;

        public UC_Registration(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void UC_Registration_Load(object sender, EventArgs e)
        {

        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.FromArgb(100, 238, 86, 132);
        }

        private void signupButton_MouseHover(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.FromArgb(100, 238, 86, 132);
        }

        private void signupButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
        }

        private void signupButton_MouseDown(object sender, MouseEventArgs e)
        {
            loginButton.ForeColor = Color.FromArgb(100, 0, 0, 255);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UC_Login ucLogin = new UC_Login(parentForm);
            parentForm.AddUserControl(ucLogin);
        }

        private void signupButon_Click(object sender, EventArgs e)
        {
            Account acc = new Account("Test");

            if (emailInput.Text != "" && passwordInput.Text != "" && confPasswordInput.Text != "" && firstNameInput.Text != "" && lastNameInput.Text != "" && streetInput.Text != "" && cityInput.Text != "" && zipInput.Text != "")
            {
                if (passwordInput.Text == confPasswordInput.Text)
                {

                }
                else
                {
                    MessageBox.Show("Passwords are not identical"); 
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out");
            }
        }
    }
}
