using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    public class Factory
    {
        public ISalesRecordAdapter SalesRecordAdapter { get; private set; }
        public ISalesRecordAnalyzer SalesRecordAnalyzer { get; private set; }

        public Factory()
        {
            //TODO: Add specific implementation classes
            this.SalesRecordAnalyzer = new WahteverYouWant();
            this.SalesRecordAdapter = new Adapter();
        }
    }
}