using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    public class SalesRecord
    {
        //Region,Country,Item Type,Sales Channel,Order Priority,Order Date
        public string Region { get; set; }

        public string Country { get; set; }
        public string ItemType { get; set; }
        public string SalesChannel { get; set; }
        public string OrderPriority { get; set; }
        public DateTime OrderDate { get; set; }
    }
}