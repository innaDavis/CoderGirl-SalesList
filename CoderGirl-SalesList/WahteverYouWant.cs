using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{
    internal class WahteverYouWant : ISalesRecordAnalyzer
    {
        //get cursor on interface and then ctrl period
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            decimal[] profits = { 1.3m, 3.44m, 4.9m };
            bool result = salesRecords.Any(record => profits.Contains(record.TotalProfit));
            return result;
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> results = salesRecords.Select(record => record.Country).ToList();
            return results;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.Country).Count();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.TotalProfit).Max();
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.TotalRevenue).Sum();
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            return salesRecords.OrderBy(record => record.ShipDate).ToList();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            return salesRecords.OrderByDescending(record => record.UnitsSold).ToList();
        }
    }
}