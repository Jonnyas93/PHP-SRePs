using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class Inventory
    {
        private Product _product;
        private int _stock;


        public Product Product
        {
            get
            {
                return _product;
            }
        }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }

        public Inventory(Product product, int stock)
        {
            _product = product;
            _stock = stock;
        }
    }
}
