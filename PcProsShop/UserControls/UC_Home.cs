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
        Form1 parentForm;
        private int pageCount;
        private int maxItemsPerPage = 6;
        private int currentPage;

        public UC_Home(int _tabIndex, Form1 parent, int page)
        {
            InitializeComponent();
            tabIndex = _tabIndex;
            parentForm = parent;
            currentPage = page;
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
                    break;

                default:
                    break;
            }

            invLength = inventory.Length;
            pageCount = invLength / maxItemsPerPage;

            if ((invLength % maxItemsPerPage) > 0)
            {
                pageCount++;
            }

            parentForm.maxPage = pageCount;

        }

        private void DisplayItems()
        {
            int itemIndex = 0 + (maxItemsPerPage * (currentPage - 1));

            if (invLength > 0)
            {
                DisplayLength(itemIndex, itemIndex +  1, item1, itemPic1, price1);
                DisplayLength(itemIndex + 1, itemIndex + 2, item2, itemPic2, price2);
                DisplayLength(itemIndex + 2, itemIndex + 3, item3, itemPic3, price3);
                DisplayLength(itemIndex + 3, itemIndex + 4, item4, itemPic4, price4);
                DisplayLength(itemIndex + 4, itemIndex + 5, item5, itemPic5, price5);
                DisplayLength(itemIndex + 5, itemIndex + 6, item6, itemPic6, price6);
            }
        }

        private void DisplayLength(int index, int requiredLength, Panel item, Panel image, Label label)
        {
            if (invLength > 6)
            {
                parentForm.EnablePageButtons();
            }
            else
            { 
                parentForm.DisablePageButtons();
            }

            if (requiredLength < invLength + 1)
            {
                item.Visible = true;
                label.Text = inventory[index].Price.ToString() + "€";
                string name = inventory[index].Name;
                DisplayImage(image, name);
            }
            else
            {
                item.Visible = false;
            }
        }

        private void DisplayImage(Panel image, string name)
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
    }
}
