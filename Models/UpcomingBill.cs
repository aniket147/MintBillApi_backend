using System;

namespace MintBillApi.Models
{
    public class UpcomingBill
    {
        public string ID { get; set; }
        public string title { get; set; }
        public int amount { get; set; }
        public string date { get; set; }
    }
}
