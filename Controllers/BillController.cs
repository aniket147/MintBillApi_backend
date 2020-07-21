using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MintBillApi.Services;
using MintBillApi.Models;

namespace MintBillApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillController : ControllerBase
    {
        public ILogger _logger;
        public BillService _service;

        public BillController(ILogger<BillController> logger, BillService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/bills")]
        public ActionResult<List<Bill>> GetBills()
        {
            return _service.GetBills();
        }

        [HttpPost("/api/bills")]
        public ActionResult<Bill> AddBill(Bill bill)
        {
            _service.AddBill(bill);
            return bill;
        }

        [HttpPut("/api/bills/{id}")]
        public ActionResult<Bill> UpdateBill(string id, Bill bill)
        {
            _service.UpdateBill(id, bill);
            return bill;
        }

        [HttpDelete("/api/bills/{id}")]
        public ActionResult<string> DeleteBill(string id)
        {
            _service.DeleteBill(id);
            return id;
        }
    }
}