using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class Product
    {
        private string _id;
        private string _name;
        private decimal _cost;
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        Product(string id, string name, decimal cost)
        {
            _id = id;
            _name = name;
            _cost = cost;
        }
    }
}
