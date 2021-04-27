using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class SalesReport
    {
        private string _id;
        private List<Sale> _sales;
        private DateTime _reportDate;

        public string ID
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
        SalesReport(string ID, List<Sale> sales, DateTime date)
        {
            _id = ID;
            _sales = sales;
            _reportDate = date;
        }
    }
}
