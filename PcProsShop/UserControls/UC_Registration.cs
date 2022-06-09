﻿using System;
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
    public partial class UC_Registration : UserControl
    {
        public UC_Registration()
        {
            InitializeComponent();
        }

        private void UC_Registration_Load(object sender, EventArgs e)
        {

        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(100, 238, 86, 132);
        }

        private void signupButton_MouseHover(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(100, 238, 86, 132);
        }

        private void signupButton_MouseLeave(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.Black;
        }

        private void signupButton_MouseDown(object sender, MouseEventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(100, 0, 0, 255);
        }
    }
}