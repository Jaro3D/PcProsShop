﻿using System;
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
    public enum Status {New, OnTheWay, Delivered}
    
    internal class Order
    {
        /*
         * Attrebutes
         */
        private int id;
        private CartItem[] orderItem;
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
        public CartItem[] OrderItem
        {
            get { return orderItem; }
            set { orderItem = value; }
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
        public Order(int id, CartItem[] item, int customerID, Status status)
        {
            ID = id;
            OrderItem = item;
            CustomerID = customerID;
            Status = status;
        }

        /*
         * Calculates the total price of the Order.
         * Return value: Double value containg the price of the Order.
         */
        public double calcTotalPrice()
        {
            double price = 0;
            for(int i = 0;i< OrderItem.Length; i++)
            {
                price += OrderItem[i].Cartitem.Price * OrderItem[i].Amount;
            }
            return price;
        }

    }
}