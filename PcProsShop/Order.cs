using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcProsShop
{
    /*
     * Enumeration for Order Object attribute Status.
     * New: Order was created.
     * OnTheWay: Order is shipping
     * Delivered: Order was deleiverd.
     */
    public enum Status
    {
        InProcess,
        InShipping,
        Delivered
    }

    internal class Order
    {
        /*
         * Attrebutes
         */
        private int id;
        private CartItem item;
        private int customerID;
        private Status status;
        
        /*
         * Setter and Getter
         */ 
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public CartItem OrderItem
        {
            get { return item; }
            set { item = value; }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        /*
         * Constructor
         */
        public Order(int id, CartItem item, int customerID, Status status)
        {
            ID = id;
            OrderItem = item;
            CustomerID = customerID;
            Status = status;
        }
    }
}
