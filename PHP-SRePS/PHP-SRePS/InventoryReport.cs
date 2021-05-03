using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace PHP_SRePS
{
    public class InventoryReport
    {
        private int _id;
        private List<Inventory> _inventories;
        private string _reportDate;

        public int ID
        {
            get
            {
                return _id;
            }
        }
        private List<Inventory> inventories
        {
            get
            {
                return _inventories;
            }
        }
        public string ReportDate
        {
            get
            {
                return _reportDate;
            }
        }

        public InventoryReport(int ID, List<Sale> Sales, string Date)
        {
            _id = ID;
            _inventories = new List<Inventory>();
            for (int i = 0; i < Sales.Count; i++)
            {
                for (int a = 0; a < Sales[i].Products.Count ; a++)
                {
                    Inventory inv = new Inventory(Sales[i].Products[a], Sales[i].Quantities[a]);
                    _inventories.Add(inv);
                }
            }
            _reportDate = Date;
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
                csv.WriteRecord(_inventories.Count); 
                csv.NextRecord();
                for (int i = 0; i < _inventories.Count; i++)
                {
                    csv.WriteRecord(_inventories[i].Product);
                    csv.WriteRecord(_inventories[i].Stock);
                    csv.NextRecord();
                }
            }
        }
        public void readCSV()
        {

        }
    }
}
