using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            List<SalesRecord> salesRecords = GetSalesRecordsFromFileData();
            int countNorthAmerica = GetCountForNorthAmerica(salesRecords);
            Console.WriteLine(countNorthAmerica);
        }

        private int GetCountForNorthAmerica(List<SalesRecord> salesRecords)
        {
            int count = 0;
            foreach(SalesRecord record in salesRecords)
            {
                if(record.Region == "North America")
                {
                    count++;
                }
            }

            return count;
        }

        private List<SalesRecord> GetSalesRecordsFromFileData()
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