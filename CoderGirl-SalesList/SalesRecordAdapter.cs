using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoderGirl_SalesList
{
    internal class SalesRecordAdapter : ISalesRecordAdapter
    {
        public List<SalesRecord> GetSalesRecordsFromCsvFile(string filePath)
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>();
            bool isFirstRow = true;
            foreach (string line in File.ReadLines(@"1000 Sales Records.csv"))
            {
                if (isFirstRow)
                {
                    isFirstRow = false;
                    continue;
                }

                SalesRecord salesRecord = CreateSalesRecord(line);
                salesRecords.Add(salesRecord);
            }
            return salesRecords;

            throw new NotImplementedException();
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

            return salesRecord;
        }
    }
}