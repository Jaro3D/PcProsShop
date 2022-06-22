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
    public partial class UC_Payment : UserControl
    {
        Form1 parentForm;
        public UC_Payment(Form1 form)
        {
            InitializeComponent();
            parentForm = form;

            DisplayData();
        }

        private void DisplayData()
        { 
            payAmountLabel.Text = CalculateTotalAmount(parentForm.cartItems).ToString() + "€";
            nameLabel.Text = parentForm.account.Fname + " " + parentForm.account.Lname;
            emailLabel.Text = parentForm.account.Mail;
            cityLabel.Text = parentForm.account.City;
            streetLabel.Text = parentForm.account.Street;
            zipCodeLabel.Text = parentForm.account.Zip;
        }

        private double CalculateTotalAmount(List<CartItem> list)
        {
            double totalAmount = 0;

            foreach (var item in list)
            {
                double tempAmount = item.Cartitem.Price * Convert.ToDouble(item.Amount);
                totalAmount += tempAmount;
            }

            return totalAmount;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Payment_Load(object sender, EventArgs e)
        {

        }

        private void confiormButton_Click(object sender, EventArgs e)
        {
            if (paymentMethodsBox.Text != "")
            {
                foreach (var item in parentForm.cartItems)
                {
                    Order tempOrder = new Order(1, item, parentForm.account.Id, Status.InProcess);
                    Database.CreateOrder(tempOrder);

                    UC_OrderCompleted ucOrderCompleted = new UC_OrderCompleted();
                    parentForm.AddUserControl(ucOrderCompleted);
                }

                parentForm.cartItems.Clear();
                parentForm.cartNotificationIcon.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a payment method");
            }
        }
    }
}
