using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _cost;
        public int ID
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

        public Product(int id, string name, decimal cost)
        {
            _id = id;
            _name = name;
            _cost = cost;
        }

        public static bool operator <(Product a, Product b)
        {
            bool res = false;
            if(a.ID < b.ID)
            {
                res = true;
            }
            return res;
        }
        public static bool operator >(Product a, Product b)
        {
            bool res = false;
            if (a.ID > b.ID)
            {
                res = true;
            }
            return res;
        }
    }
}
