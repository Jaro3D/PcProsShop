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
        Form1 form;

        public UC_Login(Form1 _form)
        {
            InitializeComponent();
            form = _form;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UC_Registration ucRegistration = new UC_Registration();
            form.AddUserControl(ucRegistration);
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
            Account accs = Database.LoadAccount(emailInput.Text, passwordInput.Text);
        }
    }
}
