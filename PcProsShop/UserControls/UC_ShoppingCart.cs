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
    public partial class UC_ShoppingCart : UserControl
    {
        Form1 parentForm;
        int currentAmount;
        private int currentItemIndex = 0;

        public UC_ShoppingCart(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadItemsToList();
            itemAmountLabel.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void LoadItemsToList()
        {
            cartItemList.Items.Clear();

            if (parentForm.cartItems.Count > 0)
            {
                editPanel.Visible = true;

                LoadSelectedItem(currentItemIndex);

                foreach (CartItem item in parentForm.cartItems)
                {
                    ListViewItem lViewItem = new ListViewItem(item.Cartitem.Name);
                    lViewItem.SubItems.Add(item.Cartitem.Price.ToString() + "€");
                    lViewItem.SubItems.Add(item.Amount.ToString());

                    cartItemList.Items.Add(lViewItem);
                }
            }
            else
            {
                editPanel.Visible = false;
            }
        }

        private void UC_ShoppingCart_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            parentForm.cartItems[currentItemIndex].Amount = currentAmount;
            LoadItemsToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            parentForm.cartItems.RemoveAt(currentItemIndex);
            currentItemIndex = 0;
            LoadItemsToList();

            if (parentForm.cartItems.Count <= 0)
            {
                parentForm.cartNotificationIcon.Visible = false;
            }
        }

        private void cartItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cartItemList.FocusedItem == null) return;
            currentItemIndex = cartItemList.FocusedItem.Index;
            LoadSelectedItem(currentItemIndex);
        }

        private void LoadSelectedItem(int selectedIndex)
        {
            itemName.Text = parentForm.cartItems[selectedIndex].Cartitem.Name;
            itemPrice.Text = parentForm.cartItems[selectedIndex].Cartitem.Price.ToString() + "€";
            currentAmount = parentForm.cartItems[selectedIndex].Amount;
            itemAmountLabel.Text = currentAmount.ToString();
        }

        private void editPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateCurrentAmount()
        {
            itemAmountLabel.Text = currentAmount.ToString();
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (currentAmount > 1)
            {
                currentAmount--;
                UpdateCurrentAmount();
            }
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {if (parentForm.cartItems[currentItemIndex].Cartitem.Amount > currentAmount)
            {
                currentAmount++;
                UpdateCurrentAmount();
            }
        }

        private void prettyButton1_Click(object sender, EventArgs e)
        {
            if (parentForm.loggedIn)
            {
                UC_Payment ucPayment = new UC_Payment(parentForm);
                parentForm.AddUserControl(ucPayment);
            }
            else
            {
                UC_Login ucLogin = new UC_Login(parentForm);
                parentForm.AddUserControl(ucLogin);
            }
        }
    }
}
