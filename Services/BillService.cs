using System;
using System.Collections.Generic;
using MintBillApi.Models;

namespace MintBillApi.Services
{
    public class BillService
    {

        public List<Bill> _billItems;

        public BillService()
        {
            _billItems = new List<Bill>();
        }

        public List<Bill> GetBills()
        {
            return _billItems;
        }

        public Bill AddBill(Bill billItem)
        {
            _billItems.Add(billItem);
            return billItem;
        }

        public Bill UpdateBill(string id, Bill billItem)
        {
            for (var index = _billItems.Count - 1; index >= 0; index--)
            {
                if (_billItems[index].ID == id)
                {
                    _billItems[index] = billItem;
                }
            }
            return billItem;
        }

        public string DeleteBill(string id)
        {
            for (var index = _billItems.Count - 1; index >= 0; index--)
            {
                if (_billItems[index].ID == id)
                {
                    _billItems.RemoveAt(index);
                }
            }

            return id;
        }


    }
}


// using System;
// using System.Collections.Generic;
// using MintBillApi.Models;

// namespace MintBillApi.Services
// {
//     public class IBillService
//     {
//         public List<Bill> GetBills(); 
//         public Bill AddBill(Bill billItem);
//         public Bill UpdateBill(string id, Bill billItem);
//         public string DeleteBill(string id);
//     }
// }