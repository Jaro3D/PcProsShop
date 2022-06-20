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
        }

        private void LoadItemsToList()
        {
            if (parentForm.cartItems.Count > 0)
            {
                foreach (CartItem item in parentForm.cartItems)
                {
                    ListViewItem lViewItem = new ListViewItem(item.Cartitem.Name);
                    lViewItem.SubItems.Add(item.Cartitem.Price.ToString() + "€");
                    lViewItem.SubItems.Add(item.Amount.ToString());

                    cartItemList.Items.Add(lViewItem);
                }
            }
        }

        private void UC_ShoppingCart_Load(object sender, EventArgs e)
        {

        }
    }
}
