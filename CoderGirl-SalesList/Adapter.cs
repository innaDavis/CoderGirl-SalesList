using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoderGirl_SalesList
{
    internal class Adapter : ISalesRecordAdapter
    {
     

        public List<SalesRecord> GetSalesRecordsFromCsvFile(string filePath)
        {
            return GetSalesRecordsFromFileData();
        }

        private List<SalesRecord> GetSalesRecordsFromFileData()
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>();
            bool isFirstRow = true;
            int counter = 0;
            foreach (string line in File.ReadLines(@"Data/1000 Sales Records.csv"))
            {
                counter++;
                if (isFirstRow)
                {
                    isFirstRow = false;
                    continue;
                }

                if (counter == 102)
                {
                    return salesRecords;
                }

                SalesRecord salesRecord = CreateSalesRecord(line);
                salesRecords.Add(salesRecord);
            }
            return salesRecords;
        }

        private SalesRecord CreateSalesRecord(string line)
        {
            SalesRecord salesRecord = new SalesRecord();
            string[] properties = line.Split(",");
            salesRecord.Region = properties[0];
            salesRecord.Country = properties[1];
            salesRecord.ItemType = properties[2];
            salesRecord.SalesChannel = properties[3];
            salesRecord.OrderPriority = properties[4];
            salesRecord.OrderDate = DateTime.Parse(properties[5]);
            salesRecord.ShipDate = DateTime.Parse(properties[7]);
            salesRecord.UnitsSold = Int32.Parse(properties[8]);
            salesRecord.TotalProfit = Decimal.Parse(properties[13]);
            salesRecord.TotalRevenue = Decimal.Parse(properties[11]);

            return salesRecord;
        }
    }
}
