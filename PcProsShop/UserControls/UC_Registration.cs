using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                
                if (verifyMailSyntax(emailInput.Text)) 
                { 
                    if (!(Database.CheckIfEmailExists(emailInput.Text.ToLower())))
                    {
                        if (passwordInput.Text == confPasswordInput.Text)
                        {
                            if (verifyPasswordSyntax(passwordInput.Text)) {
                                acc.Mail = emailInput.Text.ToLower();
                                acc.Password = passwordInput.Text;
                                acc.Fname = firstNameInput.Text;
                                acc.Lname = lastNameInput.Text;
                                acc.Street = streetInput.Text;
                                acc.City = cityInput.Text;
                                acc.Zip = zipInput.Text;

                                Database.CreateAccount(acc);

                                NotificationService.sendAccoundCreated(acc);

                                UC_Login ucLogin = new UC_Login(parentForm);
                                parentForm.AddUserControl(ucLogin);
                            }
                            else
                            {
                                MessageBox.Show("Passwords must fulfill the following conditions:\n" +
                                    "Eight letters long\nContain at least on lowercase letter\n" +
                                    "Contain at least one uppercase letter\nContain at least one number\n" +
                                    "Contain at least one symbol");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords are not identical");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email already exists");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid e-mail address");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out");
            }

            static Boolean verifyMailSyntax(String mail)
            {
                Boolean result = false;
                if (mail.Contains("@"))
                {
                    mail = mail.Substring(mail.IndexOf("@") + 1);
                    if (mail.Contains("."))
                    {
                        result = true;
                    }
                    if (mail.Contains("@"))
                    {
                        result = false;
                    }

                }
                return result;
            }

            static Boolean verifyPasswordSyntax(String password)
            {
                Boolean strength = true;
                if (password.Length < 8)
                {
                    strength = false;
                }
                Regex reg = new Regex(@"[0-9]");
                if (!reg.Match(password).Success)
                {
                    strength = false;
                }
                reg = new Regex(@"[a-z]");
                if (!reg.Match(password).Success)
                {
                    strength = false;
                }
                reg = new Regex(@"[A-Z]");
                if (!reg.Match(password).Success)
                {
                    strength = false;
                }
                reg = new Regex(@"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]");
                if (!reg.Match(password).Success)
                {
                    strength = false;
                }

                return strength;
            }

        }
    }
}
