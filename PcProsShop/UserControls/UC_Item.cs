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
    public partial class UC_Item : UserControl
    {
        Form1 parentForm;
        UC_Home lastForm;
        Item item;
        public UC_Item(Form1 form, UC_Home previousForm, Item loadedItem)
        {
            InitializeComponent();
            this.parentForm = form;
            this.item = loadedItem;
            this.lastForm = previousForm;
            LoadItem();
        }

        private void LoadItem()
        { 
            itemNameLabel.Text = item.Name;
            lastForm.DisplayImage(itemPic, item.Name);
        }

        private void UC_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
