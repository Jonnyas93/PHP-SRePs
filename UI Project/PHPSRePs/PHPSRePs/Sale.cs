using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class Sale
    {
        private int _id;
        private int _userId;
        private Product _product;
        private int _quantity;
        private DateTime _saleDate;

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public int UserID
        {
            get
            {
                return _userId;
            }
        }
        public Product Product
        {
            get
            {
                return _product;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public DateTime Date
        {
            get
            {
                return _saleDate;
            }
        }

        public Sale(int ID, int UserID, Product product, int quantities, DateTime salesDate)
        {
            _id = ID;
            _userId = UserID;
            _product = product;
            _quantity = quantities;
            _saleDate = salesDate;
        }
        public decimal GetTotal()
        {
            decimal total = Quantity * Product.Cost;
            return total;
        }
        //public string ItemList()
        //{
        //    string msg = "";
        //    for (int i = 0; i < Products.Count; i++)
        //    {
        //        string txt = "Name: " + _products[i].ToString()+ "| Cost:" + _products[i].Cost.ToString() + "| Quantity: " + _quantities[i].ToString() + "\n";
        //        msg += txt;
        //    }
        //    msg += "--------------------";
        //    msg += "Total: " + GetTotal().ToString();
        //    return msg;
        //}
        //public Product GetItem(int ID)
        //{
        //    for (int i = 0; i < Products.Count; i++)
        //    {
        //        if (_products[i].ID == ID)
        //        {
        //            return _products[i];    
        //        }
        //    }
        //    return null;
        //}

        //public void AddItem(Product product, int quantity)
        //{//check for existing item
        //    for (int i = 0; i < Products.Count; i++)
        //    {
        //        if (_products[i].ID == ID)
        //        {
        //            _quantities[i] += quantity;
        //            return;
        //        }
        //    }
        //    _products.Add(product);
        //    _quantities.Add(quantity);
        //}

        //public void RemoveItem(int ID, int quantity)
        //{
        //    for (int i = 0; i < Products.Count; i++)
        //    {
        //        if (_products[i].ID == ID)
        //        {
        //            if(_quantities[i] > quantity)
        //            {
        //                _quantities[i] -= quantity;
        //            }
        //            else
        //            {
        //                _quantities.RemoveAt(i);
        //                _products.RemoveAt(i);
        //            }
        //        }
        //    }
        //}
    }
}
