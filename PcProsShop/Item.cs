using System;
namespace PcProsShop
{
	public class Item
	{
		/*
         * Attributes
         */
		private int itemID;
		private string name;
		private string brand;
		private string info;
		private string category;
		private int amount;
		private double price;

		/*
		* Setter and Getter
		*/
		public int ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}
		public string Info
		{
			get { return info; }
			set { info = value; }
		}
		public string Category
		{
			get { return category; }
			set { category = value; }
		}
		public int Amount
		{
			get { return amount; }
			set { amount = value; }
		}
		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		/*
         * Constructors
         */
		public Item()
		{
		}
		public Item(int itemID, string name, string brand, string info, string category, int amount, double price)
        {
            ItemID = itemID;
            Name = name;
            Brand = brand;
            Info = info;
            Category = category;
            Amount = amount;
            Price = price;
        }
    }

}
