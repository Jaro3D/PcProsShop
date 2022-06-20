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

                LoadSelectedItem(0);

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
            int selectIndex = cartItemList.Items.IndexOf(cartItemList.SelectedItems[0]);
            MessageBox.Show(selectIndex.ToString());
            LoadSelectedItem(selectIndex);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            parentForm.cartItems.RemoveAt(cartItemList.Items.IndexOf(cartItemList.SelectedItems[0]));
            LoadItemsToList();
        }

        private void cartItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cartItemList.FocusedItem == null) return;
            int i = cartItemList.FocusedItem.Index;
            LoadSelectedItem(i);
        }

        private void LoadSelectedItem(int selectedIndex)
        {
            itemName.Text = parentForm.cartItems[selectedIndex].Cartitem.Name;
            itemPrice.Text = parentForm.cartItems[selectedIndex].Cartitem.Price.ToString() + "€";
            itemAmountLabel.Text = parentForm.cartItems[selectedIndex].Amount.ToString();
        }
    }
}
