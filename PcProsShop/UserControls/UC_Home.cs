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
        private int tabIndex;
        private Item[] inventory;
        int invLength;
        Form1 parentForm;
        private int pageCount;
        private int maxItemsPerPage = 6;
        private int currentPage;
        private int itemIndex = 0;

        private Panel[] items = new Panel[6];
        private Panel[] images = new Panel[6];
        private Label[] prices = new Label[6];

        public UC_Home(int _tabIndex, Form1 parent, int page)
        {
            InitializeComponent();
            tabIndex = _tabIndex;
            parentForm = parent;
            currentPage = page;
            GetElements();
            LoadItems();
            DisplayItems();
        }

        private void GetElements()
        {
            items[0] = item1;
            items[1] = item2;
            items[2] = item3;
            items[3] = item4;
            items[4] = item5;
            items[5] = item6;

            images[0] = itemPic1;
            images[1] = itemPic2;
            images[2] = itemPic3;
            images[3] = itemPic4;
            images[4] = itemPic5;
            images[5] = itemPic6;

            prices[0] = price1;
            prices[1] = price2;
            prices[2] = price3;
            prices[3] = price4;
            prices[4] = price5;
            prices[5] = price6;
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
                    break;

                default:
                    break;
            }

            invLength = inventory.Length;
            int tempInvLength = invLength;

            //Detect items that are out of stock
            for (int i = 0; i < tempInvLength; i++)
            {
                if (inventory[i].Amount < 1)
                {
                    invLength--;
                }
            }

            inventory = DeleteEmptyItems(inventory, invLength);

            pageCount = invLength / maxItemsPerPage;

            if ((invLength % maxItemsPerPage) > 0)
            {
                pageCount++;
            }

            parentForm.maxPage = pageCount;

        }

        private Item[] DeleteEmptyItems(Item[] inv, int newLength)
        {
            Item[] newInv = new Item[newLength];
            int oldIndex = 0;

            for (int i = 0; i < newLength; i++)
            {
                while (true)
                {
                    if (inv[oldIndex].Amount > 0)
                    {
                        newInv[i] = inv[oldIndex];
                        break;
                    }
                    oldIndex++;
                }
                oldIndex++;
            }

            return newInv;
        }

        private void DisplayItems()
        {
            itemIndex = 0 + (maxItemsPerPage * (currentPage - 1));

            if (invLength > 6)
            {
                parentForm.EnablePageButtons();
            }
            else
            {
                parentForm.DisablePageButtons();
            }

            if (invLength > 0)
            {
                HideAllItems();

                for (int i = 0; i < maxItemsPerPage; i++)
                {
                    if ((invLength - itemIndex) > i)
                    {
                        items[i].Visible = true;
                        prices[i].Text = inventory[i + itemIndex].Price.ToString() + "€";
                        DisplayImage(images[i], inventory[i + itemIndex].Name);
                    }
                }
            }
        }

        private void HideAllItems()
        {
            for (int i = 0; i < maxItemsPerPage; i++)
            {
                items[i].Visible = false;
            }
        }

        public void DisplayImage(Panel image, string name)
        {
            switch (name)
            {
                //RAM
                case "16GB Trident Z":
                    image.BackgroundImage = Properties.Resources.Item_16GB_Trident_Z;
                    break;
                
                //CPU
                case "Ryzen 5 5600X":
                    image.BackgroundImage = Properties.Resources.Item_Ryzen5_5600X;
                    break;
                case "i9 12900KS":
                    image.BackgroundImage = Properties.Resources.Item_i9_12900KS;
                    break;

                //GPU
                case "RTX3050":
                    image.BackgroundImage = Properties.Resources.Item_RTX3050;
                    break;
                case "RTX3060 Ti":
                    image.BackgroundImage = Properties.Resources.Item_RTX3060Ti;
                    break;
                case "RTX3080":
                    image.BackgroundImage = Properties.Resources.Item_RTX3080;
                    break;
                case "RTX3090 Ti":
                    image.BackgroundImage = Properties.Resources.Item_RTX3090Ti;
                    break;
                case "RX6500 XT":
                    image.BackgroundImage = Properties.Resources.Item_RX6500XT;
                    break;
                case "RX6600 XT":
                    image.BackgroundImage = Properties.Resources.Item_RX6600XT;
                    break;
                case "RX6800 XT":
                    image.BackgroundImage = Properties.Resources.Item_RX6800XT;
                    break;
                case "RX6950 XT":
                    image.BackgroundImage = Properties.Resources.Item_RX6950XT;
                    break;

                default:
                    break;
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

            itemPic1.BackColor = Color.FromArgb(0, Color.Black);
            itemPic2.BackColor = Color.FromArgb(0, Color.Black);
            itemPic3.BackColor = Color.FromArgb(0, Color.Black);
            itemPic4.BackColor = Color.FromArgb(0, Color.Black);
            itemPic5.BackColor = Color.FromArgb(0, Color.Black);
            itemPic6.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void itemPic1_MouseDown(object sender, MouseEventArgs e)
        {
            parentForm.DisableNavButtons();
            UC_Item ucItem = new UC_Item(parentForm, this, inventory[0 + (maxItemsPerPage* (currentPage - 1))]);
            parentForm.AddUserControl(ucItem);
        }
    }
}
