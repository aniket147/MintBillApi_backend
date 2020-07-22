using System;
using System.Collections.Generic;
using MintBillApi.Models;

namespace MintBillApi.Services
{
    public class UpcomingBillService
    {

        public List<UpcomingBill> _billItems;

        public UpcomingBillService()
        {
            _billItems = new List<UpcomingBill>();
        }

        public List<UpcomingBill> GetUpcomingBills()
        {
            return _billItems;
        }

        public UpcomingBill AddUpcomingBill(UpcomingBill billItem)
        {
            _billItems.Add(billItem);
            return billItem;
        }

        public UpcomingBill UpdateUpcomingBill(string id, UpcomingBill billItem)
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

        public string DeleteUpcomingBill(string id)
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