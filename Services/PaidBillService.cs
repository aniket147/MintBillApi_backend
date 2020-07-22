using System;
using System.Collections.Generic;
using MintBillApi.Models;

namespace MintBillApi.Services
{
    public class PaidBillService
    {

        public List<PaidBill> _billItems;

        public PaidBillService()
        {
            _billItems = new List<PaidBill>();
        }

        public List<PaidBill> GetPaidBills()
        {
            return _billItems;
        }

        public PaidBill AddPaidBill(PaidBill billItem)
        {
            _billItems.Add(billItem);
            return billItem;
        }

        public PaidBill UpdatePaidBill(string id, PaidBill billItem)
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

        public string DeletePaidBill(string id)
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