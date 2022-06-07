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
    public partial class UC_Home : UserControl
    {
        int tabIndex;
        private Item[] inventory;
        int invLength;

        public UC_Home(int _tabIndex)
        {
            InitializeComponent();
            tabIndex = _tabIndex;
            LoadItems();
            DisplayItems();
            
        }

        private void LoadItems()
        {
            switch (tabIndex)
            {
                case 0:
                    invLength = Database.LoadInventory(Category.GPU).Length;
                    inventory = new Item[invLength];
                    inventory = Database.LoadInventory(Category.GPU);
                    break;

                case 1:
                    invLength = Database.LoadInventory(Category.CPU).Length;
                    inventory = new Item[invLength];
                    inventory = Database.LoadInventory(Category.CPU);
                    break;

                case 2:
                    invLength = Database.LoadInventory(Category.RAM).Length;
                    inventory = new Item[invLength];
                    inventory = Database.LoadInventory(Category.RAM);
                    MessageBox.Show("RAM");
                    break;

                default:
                    break;
            }

            invLength = inventory.Length;
        }

        private void DisplayItems()
        {
            if (invLength > 0)
            {
                DisplayLength(0, 2, item1, price1);
                DisplayLength(1, 3, item2, price2);
                DisplayLength(2, 4, item3, price3);
                DisplayLength(3, 5, item4, price4);
                DisplayLength(4, 6, item5, price5);
                DisplayLength(5, 7, item6, price6);
            }
        }

        private void DisplayLength(int index, int length, Panel item, Label label)
        {
            if (length < invLength)
            {
                item.Visible = true;
                label.Text = inventory[index].Price.ToString() + "€";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            item1.BackColor = Color.FromArgb(0, Color.Black);
            item2.BackColor = Color.FromArgb(0, Color.Black);
            item3.BackColor = Color.FromArgb(0, Color.Black);
            item4.BackColor = Color.FromArgb(0, Color.Black);
            item5.BackColor = Color.FromArgb(0, Color.Black);
            item6.BackColor = Color.FromArgb(0, Color.Black);

            price1.BackColor = Color.FromArgb(0, Color.Black);
            price2.BackColor = Color.FromArgb(0, Color.Black);
            price3.BackColor = Color.FromArgb(0, Color.Black);
            price4.BackColor = Color.FromArgb(0, Color.Black);
            price5.BackColor = Color.FromArgb(0, Color.Black);
            price6.BackColor = Color.FromArgb(0, Color.Black);
        }
    }
}
