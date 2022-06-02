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
        public UC_Home()
        {
            InitializeComponent();
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
        }
    }
}
