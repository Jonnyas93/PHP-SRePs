using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace PHP_SRePS
{
    public class SalesReport
    {
        private int _id;
        private List<Sale> _sales;
        private DateTime _reportDate;

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public List<Sale> Sales
        {
            get
            {
                return _sales;
            }
        }
        public DateTime ReportDate
        {
            get
            {
                return _reportDate;
            }
        }
        public SalesReport(int ID, List<Sale> sales, DateTime date)
        {
            _id = ID;
            _sales = sales;
            _reportDate = date;
        }

        public string SalesListString()
        {
            {
                string msg = "";
                decimal total = 0;
                for (int i = 0; i < _sales.Count; i++)
                {
                    decimal subtotal = _sales[i].GetTotal();
                    string txt = "Sale ID: " + _sales[i].ID + "| Sale Date: " + _sales[i].Date.Date.ToString() + "| User ID: " + _sales[i].UserID + "| Subtotal: $" + subtotal.ToString();
                    msg += txt;
                    total += subtotal;
                }
                msg += "-----------------------------";
                msg += "Total: $" + total.ToString();
                return msg;
            }
        }
        public List<Product> SalesList()
        {
            List<Product> distinctProducts = new List<Product>();
            for (int i = 0; i < _sales.Count; i++)
            {
                for (int a = 0; a < _sales[i].Products.Count; a++)
                {
                    for (int b = 0; b < distinctProducts.Count; b++)
                    {
                        if (_sales[i].Products[a].ID == distinctProducts[b].ID)
                        {
                            break;
                        }
                        distinctProducts.Add(_sales[i].Products[b]);
                    }
                }
            }
            distinctProducts.Sort();
            return distinctProducts;
        }
        public void writeCSV(string name)
        {
            string fullname = name + ".csv";
            using (var writer = new StreamWriter(fullname))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                writer.Flush();
                csv.WriteRecord(_id);
                csv.WriteRecord(_reportDate);
                csv.NextRecord();
                for (int i = 0; i < _sales.Count; i++)
                {
                    csv.WriteRecord(_sales[i].ID);
                    csv.WriteRecord(_sales[i].UserID);
                    csv.WriteRecord(_sales[i].Date);
                    csv.NextRecord();
                    for (int a = 0; a < _sales[i].Products.Count; a++)
                    {
                        csv.WriteRecord(_sales[i].Products[a].ID);
                        csv.WriteRecord(_sales[i].Products[a].Name);
                        csv.WriteRecord(_sales[i].Products[a].Cost);
                        csv.WriteRecord(_sales[i].Quantities[a]);
                        csv.NextRecord();
                    }
                    
                }
            }
        }
        public void readCSV()
        {

        }
    }
}
