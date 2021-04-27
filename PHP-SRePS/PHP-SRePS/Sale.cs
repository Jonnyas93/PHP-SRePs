using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class Sale
    {
        private string _id;
        private string _userId;
        private List<Product> _products;
        private List<int> _quantities;
        private DateTime _saleDate;
        

        public string ID
        {
            get
            {
                return _id;
            }
        }
        public string UserID
        {
            get
            {
                return _userId;
            }
        }
        public List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public List<int> Quantities
        {
            get
            {
                return _quantities;
            }
        }

        public DateTime Date
        {
            get
            {
                return _saleDate;
            }
        }

        Sale(string ID, List<Product> products, List<int> quantities, DateTime salesDate)
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
            for (int i = 0; i < Products.Count; i++)
            {
                quantity = (int)Convert.ToDecimal(_quantities[i]);
                total += (_products[i].Cost * quantity);
            }
            return total;
        }
        public string GetItemList()
        {
            string msg = "";
            for (int i = 0; i < Products.Count; i++)
            {
                string txt = "Name: " + _products[i].ToString() + "| Quantity:" + _quantities[i].ToString() + "\n";
                msg += txt;
            }
            return msg;
        }
        public Product GetItem(string ID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (_products[i].ID == ID)
                {
                    return _products[i];    
                }
            }
            return null;
        }

        public void AddItem(Product product, int quantity)
        {//check for existing item
            for (int i = 0; i < Products.Count; i++)
            {
                if (_products[i].ID == ID)
                {
                    return;
                }
            }
            _products.Add(product);
            _quantities.Add(quantity);
        }

        public void RemoveItem(string ID, int quantity)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (_products[i].ID == ID)
                {
                    if(_quantities[i] > quantity)
                    {
                        _quantities[i] -= quantity;
                    }
                    else
                    {
                        _quantities.RemoveAt(i);
                        _products.RemoveAt(i);
                    }
                }
            }
        }
    }
}
