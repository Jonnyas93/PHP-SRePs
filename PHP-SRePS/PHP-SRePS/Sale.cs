using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class Sale
    {
        private string _id;
        private Product[] _products;
        private int[] _quantities;
        private DateTime _saleDate;

        public string ID
        {
            get
            {
                return _id;
            }
        }
        public Product[] Products
        {
            get
            {
                return _products;
            }
        }
        public int[] Quantities
        {
            get
            {
                return _quantities;
            }
        }

        Sale(string ID, Product[] products, int[] quantities, DateTime salesDate)
        {
            _id = ID;
            _products = products;
            _quantities = quantities;
            _saleDate = salesDate;
        }
        public decimal GetTotal()
        {
            decimal total = 0;
            int quantity;
            for (int i = 0; i < Products.Length; i++)
            {
                quantity = (int)Convert.ToDecimal(_quantities[i]);
                total += (_products[i].Cost * quantity);
            }
            return total;
        }
        public string GetItemList()
        {
            string msg = "";
            for (int i = 0; i < Products.Length; i++)
            {
                string txt = "Name: " + _products[i].ToString() + "| Quantity:" + _quantities[i].ToString() + "\n";
                msg += txt;
            }
            return msg;
        }
        public string GetItemDetails()
        {

        }
    }
}
