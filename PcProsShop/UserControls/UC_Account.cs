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
    public partial class UC_Account : UserControl
    {
        Form1 parentForm;
        Account acc;

        private bool viewMode = true;

        public UC_Account(Form1 parent, Account account)
        {
            InitializeComponent();
            parentForm = parent;
            acc = account;
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            ViewMode();
        }

        private void ViewMode()
        {
            //ViewMode elements
            nameLabel.Visible = true;
            emailLabel.Visible = true;
            cityLabel.Visible = true;
            streetLabel.Visible = true;
            zipCodeLabel.Visible = true;

            editAccountButton.Text = "Edit";
            editAccountButton.BackgroundColor = Color.FromArgb(100, 238, 86, 132);

            nameLabel.Text = acc.Fname + " " + acc.Lname;
            emailLabel.Text = acc.Mail;
            cityLabel.Text = acc.City;
            streetLabel.Text = acc.Street;
            zipCodeLabel.Text = acc.Zip;
            nameFirstChar.Text = parentForm.accChar.Text;

            //EditMode elements
            saveAccountButton.Visible = false;
            editPanel.Visible = false;
        }

        private void EditMode()
        { 
            //ViewMode elements
            emailLabel.Visible = false;
            cityLabel.Visible = false;
            streetLabel.Visible = false;
            zipCodeLabel.Visible = false;

            //EditMode elements
            editPanel.Visible = true;
            saveAccountButton.Visible = true;
            editAccountButton.Text = "Discard";
            nameLabel.Text = acc.Mail;
            editAccountButton.BackgroundColor = Color.Red;
        }

        private void CheckMode()
        {
            if (viewMode)
            {
                ViewMode();
            }
            else
            {
                EditMode();
            }
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            viewMode = !viewMode;
            CheckMode();
        }

        private void saveAccountButton_Click(object sender, EventArgs e)
        {
            if (!(firstNameInput.Text == "" && lastNameInput.Text == "" && cityInput.Text == "" && streetInput.Text == "" && zipInput.Text == ""))
            {
                if (firstNameInput.Text != "")
                {
                    acc.Fname = firstNameInput.Text;
                }

                if (lastNameInput.Text != "")
                {
                    acc.Lname = lastNameInput.Text;
                }

                if (cityInput.Text != "")
                {
                    acc.City = cityInput.Text;
                }

                if (streetInput.Text != "")
                {
                    acc.Street = streetInput.Text;
                }

                if (zipInput.Text != "")
                {
                    acc.Zip = zipInput.Text;
                }

                Database.UpdateAccount(acc);

                //Changes data will be loaded
                Account tempAcc = Database.LoadAccount(acc.Mail, acc.Password);
                char accName = tempAcc.Fname[0];
                parentForm.account = tempAcc;
                parentForm.accChar.Text = accName.ToString();

                parentForm.SwitchTab();
            }
            else
            {
                MessageBox.Show("No data has been changed");
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            parentForm.account = null;
            parentForm.accChar.Visible = false;
            parentForm.loggedIn = false;
            parentForm.tabIndex = 0;
            parentForm.SwitchTab();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            UC_Order ucOrder = new UC_Order(parentForm);
            parentForm.AddUserControl(ucOrder);
        }
    }
}
