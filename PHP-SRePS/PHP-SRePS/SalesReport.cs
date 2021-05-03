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
        public SalesReport()
        {
            _id = 999999999;
            _sales = new List<Sale>();
            _reportDate = DateTime.Today;
        }

        public string SalesListString()
        {
            {
                string msg = "";
                decimal total = 0;
                for (int i = 0; i < _sales.Count; i++)
                {
                    decimal subtotal = _sales[i].GetTotal();
                    string txt = "Sale ID: " + _sales[i].ID + "| Sale Date: " + _sales[i].Date.ToString() + "| User ID: " + _sales[i].UserID + "| Subtotal: $" + subtotal.ToString();
                    msg += txt;
                    total += subtotal;
                }
                msg += "-----------------------------";
                msg += "Total: $" + total.ToString();
                return msg;
            }
        }
        public List<Inventory> SalesList()
        {
            List<Inventory> distinctProducts = new List<Inventory>();
            for (int i = 0; i < _sales.Count; i++)
            {
                for (int a = 0; a < _sales[i].Products.Count; a++)
                {
                    for (int b = 0; b < distinctProducts.Count; b++)
                    {
                        if (_sales[i].Products[a].ID == distinctProducts[b].Product.ID)
                        {
                            distinctProducts[b].Stock += _sales[i].Quantities[a];
                            break;
                        }
                        Inventory tempInv = new Inventory(_sales[i].Products[a], _sales[i].Quantities[a]);
                        distinctProducts.Add(tempInv);
                    }
                }
            }
            return distinctProducts;
        }

        private List<string> InvListProdToStringList(List<Inventory> invList)
        {
            List<string> prodNames = new List<string>();
            for (int i = 0; i < invList.Count; i++)
            {
                prodNames.Add(invList[i].Product.Name);
            }
            return prodNames;
        }
        private List<int> InvListProdToIntList(List<Inventory> invList)
        {
            List<int> prodQty = new List<int>();
            for (int i = 0; i < invList.Count; i++)
            {
                prodQty.Add(invList[i].Stock);
            }
            return prodQty;
        }
        public void writeCSV(string name)
        {
            string fullname = name + ".csv";
            using (var writer = new StreamWriter(fullname))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecord(_id);
                csv.NextRecord();
                csv.WriteRecord(_sales.Count);
                csv.NextRecord();
                for (int i = 0; i < _sales.Count; i++)
                {
                    csv.WriteRecord(_sales[i].ID);
                    csv.NextRecord();
                    csv.WriteRecord(_sales[i].UserID);
                    csv.NextRecord();
                    csv.WriteRecord(_sales[i].Products.Count);
                    csv.NextRecord();
                    for (int a = 0; a < _sales[i].Products.Count; a++)
                    {
                        csv.WriteRecord(_sales[i].Products[a].ID);
                        csv.WriteField(_sales[i].Products[a].Name);
                        csv.WriteField(_sales[i].Products[a].Cost.ToString());
                        csv.WriteRecord(_sales[i].Quantities[a]);
                        csv.NextRecord();
                    }

                }
            }
        }
        public void readCSV(string name)
        {
            List<Sale> Sales = new List<Sale>();
            DateTime control = DateTime.Today;
            string fullname = name + ".csv";
            using (var reader = new StreamReader(fullname))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                string idString = csv.GetField(0);
                int ID = int.Parse(idString);
                int salesCount = csv.GetRecord<int>();
                csv.Read();
                for (int i = 0; i < salesCount; i++)
                {
                    int saleId = csv.GetRecord<int>();
                    csv.Read();
                    int saleUserId = csv.GetRecord<int>();
                    csv.Read();
                    int prodCount = csv.GetRecord<int>();
                    csv.Read();
                    List<Product> tempProducts = new List<Product>();
                    List<int> tempQuantity = new List<int>();
                    Sale tempSale = new Sale(saleId, saleUserId, tempProducts, tempQuantity, control);
                    for (int a = 0; a < prodCount; a++)
                    {
                        int prodID = csv.GetRecord<int>();
                        csv.Read();
                        string prodName = csv.GetRecords<string>();
                        csv.Read();
                        string prodPriceString = csv.GetField(0);
                        decimal prodPrice = decimal.Parse(prodPriceString);
                        csv.Read();
                        int prodQ = csv.GetRecord<int>();
                        csv.Read();
                        Product tempProd = new Product(prodID, prodName, prodPrice);
                        tempSale.AddItem(tempProd, prodQ);
                    }
                    Sales.Add(tempSale);
                }
                _id = ID;
                _reportDate = control;
                _sales = Sales;
            }
        }
    }
}
