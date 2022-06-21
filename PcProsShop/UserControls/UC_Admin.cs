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
    public partial class UC_Admin : UserControl
    {
        private Item[] inventory;
        private int currentAmount;

        public UC_Admin()
        {
            InitializeComponent();
            LoadItemsToList();
            itemAmountLabel.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void UC_Admin_Load(object sender, EventArgs e)
        {

        }

        private void LoadItemsToList()
        {
            int invLength = Database.LoadAllInventory().Length;
            inventory = new Item[invLength];
            inventory = Database.LoadAllInventory();

            if (invLength > 0)
            {
                inventoryListView.Items.Clear();
                LoadSelectedItem(0);

                for (int i = 0; i < invLength; i++)
                {
                    ListViewItem lViewItem = new ListViewItem(inventory[i].Name);
                    lViewItem.SubItems.Add(inventory[i].Price.ToString() + "€");
                    lViewItem.SubItems.Add(inventory[i].Amount.ToString());

                    inventoryListView.Items.Add(lViewItem);
                }
            }
        }

        private void LoadSelectedItem(int itemIndex)
        { 
            nameLabel.Text = inventory[itemIndex].Name;
            priceInput.Text = inventory[itemIndex].Price.ToString();
            infoInput.Text = inventory[itemIndex].Info.ToString();
            currentAmount = inventory[itemIndex].Amount;
            itemAmountLabel.Text = currentAmount.ToString();
        }
    }
}
