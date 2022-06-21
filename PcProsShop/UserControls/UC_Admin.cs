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
        private Item currentItem;
        private int currentAmount;
        private int currentItemIndex = 0;

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
                LoadSelectedItem(currentItemIndex);

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

            currentItem = inventory[itemIndex];
        }

        private void inventoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListView.FocusedItem == null) return;
            currentItemIndex = inventoryListView.FocusedItem.Index;
            LoadSelectedItem(currentItemIndex);
        }

        private void UpdateCurrentAmount()
        {
            itemAmountLabel.Text = currentAmount.ToString();
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (currentAmount > 0)
            {
                currentAmount--;
                UpdateCurrentAmount();
            }
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (currentAmount < 100)
            {
                currentAmount++;
                UpdateCurrentAmount();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bool anythingChanged = false;

            if (currentItem.Price != Convert.ToDouble(priceInput.Text))
            {
                anythingChanged = true;
                currentItem.Price = Convert.ToDouble(priceInput.Text);
            }

            if (currentItem.Info != infoInput.Text)
            {
                anythingChanged = true;
                currentItem.Info = infoInput.Text;
            }

            if (currentItem.Amount != Convert.ToInt32(itemAmountLabel.Text))
            {
                anythingChanged = true;
                currentItem.Amount = Convert.ToInt32(itemAmountLabel.Text);
            }

            if (anythingChanged)
            {
                Database.UpdateItem(currentItem);
                LoadItemsToList();
            }
            else
            {
                MessageBox.Show("Nothing was changed");
            }
        }
    }
}
