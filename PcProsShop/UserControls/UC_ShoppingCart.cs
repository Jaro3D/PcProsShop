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
            MessageBox.Show(cartItemList.Items.IndexOf(cartItemList.SelectedItems[0]).ToString());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            parentForm.cartItems.RemoveAt(cartItemList.Items.IndexOf(cartItemList.SelectedItems[0]));
            LoadItemsToList();
        }
    }
}
