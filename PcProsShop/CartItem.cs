using System;
namespace PcProsShop
{
	public class CartItem
	{
		/*
		 * Attributes
		 */
		private Item cartItem;
		private int amount;
		
		/*
		 * Setter and Getter
		 */
		public Item Cartitem
		{
			get { return cartItem; }
			set { cartItem = value; }
		}
		public int Amount
		{
			get { return amount; }
			set { amount = value; }
		}
		
		/*
         * Constructor
         */
		public CartItem(Item item, int ammount)
		{
			Cartitem = item;
			Amount = ammount;
		}
	}

}
