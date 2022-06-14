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

        public UC_Account(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            nameLabel.Text = parentForm.account.Fname + " " + parentForm.account.Lname;
            emailLabel.Text = parentForm.account.Mail;
            cityLabel.Text = parentForm.account.City;
            streetLabel.Text = parentForm.account.Street;
            zipCodeLabel.Text = parentForm.account.Zip;
            nameFirstChar.Text = parentForm.accChar.Text;
        }
    }
}
