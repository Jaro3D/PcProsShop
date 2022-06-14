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

        private bool viewMode = true;

        public UC_Account(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            ViewMode();
        }

        private void ViewMode()
        {
            nameLabel.Visible = true;
            emailLabel.Visible = true;
            cityLabel.Visible = true;
            streetLabel.Visible = true;
            zipCodeLabel.Visible = true;
            saveAccountButton.Visible = false;

            editAccountButton.Text = "Edit";
            editAccountButton.BackColor = Color.FromArgb(100, 238, 86, 132);


            nameLabel.Text = parentForm.account.Fname + " " + parentForm.account.Lname;
            emailLabel.Text = parentForm.account.Mail;
            cityLabel.Text = parentForm.account.City;
            streetLabel.Text = parentForm.account.Street;
            zipCodeLabel.Text = parentForm.account.Zip;
            nameFirstChar.Text = parentForm.accChar.Text;
        }

        private void EditMode()
        { 
            nameLabel.Visible = false;
            emailLabel.Visible = false;
            cityLabel.Visible = false;
            streetLabel.Visible = false;
            zipCodeLabel.Visible = false;
            saveAccountButton.Visible = true;

            editAccountButton.Text = "Discard";
            editAccountButton.BackColor = Color.Red;
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
    }
}
