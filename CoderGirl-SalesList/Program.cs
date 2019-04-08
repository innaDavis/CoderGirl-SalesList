using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class Program
    {
        private string filePath = @"Data/1000 Sales Records.csv";

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            Factory factory = new Factory();
            ISalesRecordAdapter salesRecordAdapter = factory.SalesRecordAdapter;
            ISalesRecordAnalyzer salesRecordAnalyzer = factory.SalesRecordAnalyzer;

            List<SalesRecord> salesRecords = salesRecordAdapter.GetSalesRecordsFromCsvFile(filePath);

            List<string> countries = salesRecordAnalyzer.GetCountries(salesRecords);
            countries.Sort();
            countries.ForEach(country => Console.WriteLine(country));

            int countryCount = salesRecordAnalyzer.GetCountryCount(salesRecords);
            Console.WriteLine(countryCount);

            decimal maxProfit = salesRecordAnalyzer.GetMaxProfit(salesRecords);
            Console.WriteLine(maxProfit);

            Console.ReadLine();
        }

       
    }
}