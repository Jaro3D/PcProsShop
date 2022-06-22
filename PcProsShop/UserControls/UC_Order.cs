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
    public partial class UC_Order : UserControl
    {
        Form1 parentForm;
        private Order[] orders;
        private Order currentOrder;
        private int currentOrderIndex = 0;

        public UC_Order(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            editPanel.Visible = false;
            LoadOrdersToList();
        }

        private void UC_Order_Load(object sender, EventArgs e)
        {

        }

        private void LoadOrdersToList()
        {
            int ordersLength = Database.LoadAllOrders(parentForm.account.Id).Length;
            orders = new Order[ordersLength];
            orders = Database.LoadAllOrders(parentForm.account.Id);

            if (ordersLength > 0)
            {
                editPanel.Visible = true;
                orderViewList.Items.Clear();
                LoadSelectedOrder(currentOrderIndex);

                for (int i = 0; i < ordersLength; i++)
                {
                    ListViewItem lViewItem = new ListViewItem(orders[i].Item.Cartitem.Name);
                    lViewItem.SubItems.Add(orders[i].Item.Cartitem.Price.ToString() + "€");
                    lViewItem.SubItems.Add(orders[i].Item.Amount.ToString());

                    orderViewList.Items.Add(lViewItem);
                }
            }
        }

        private void LoadSelectedOrder(int orderIndex)
        {
            orderNameLabel.Text = orders[orderIndex].Item.Cartitem.Name;
            orderPrice.Text = orders[orderIndex].Item.Cartitem.Price.ToString() + "€";

            switch (orders[orderIndex].Status)
            {
                case Status.InProcess:
                    statusLabel.Text = "In process";
                    break;
                case Status.InShipping:
                    statusLabel.Text = "In shipping";
                    break;
                case Status.Delivered:
                    statusLabel.Text = "Delivered";
                    break;
                default:
                    break;
            }

            currentOrder = orders[orderIndex];
        }

        private void orderViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderViewList.FocusedItem == null) return;
            currentOrderIndex = orderViewList.FocusedItem.Index;
            LoadSelectedOrder(currentOrderIndex);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (currentOrder.Status.Equals(Status.InProcess))
            {
                Database.DeleteOrder(currentOrder);
                LoadOrdersToList();
            }
            else
            {
                MessageBox.Show("The order can no longer be canceled because it is already in delivery.");
            }
        }

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            if (currentOrder.Status.Equals(Status.InProcess))
            {
                currentOrder.Status = Status.InShipping;
            }
            else if (currentOrder.Status.Equals(Status.InShipping))
            {
                currentOrder.Status = Status.Delivered;
            }
            else if (currentOrder.Status.Equals(Status.Delivered))
            {
                currentOrder.Status = Status.InProcess;
            }

            Database.UpdateOrderStatus(currentOrder);

            LoadOrdersToList();
        }
    }
}
