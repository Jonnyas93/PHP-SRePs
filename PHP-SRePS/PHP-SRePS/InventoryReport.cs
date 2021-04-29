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
        private DateTime _reportDate;

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
        public DateTime ReportDate
        {
            get
            {
                return _reportDate;
            }
        }

        public InventoryReport(int ID, List<Sale> Sales, DateTime Date)
        {
            _id = ID;
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
                for (int i = 0; i < _inventories.Count; i++)
                {
                    
                    csv.NextRecord();
                }
            }
        }
        public void readCSV()
        {

        }
    }
}
