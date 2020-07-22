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
    public class PaidBillController : ControllerBase
    {
        public ILogger _logger;
        public PaidBillService _service;

        public PaidBillController(ILogger<PaidBillController> logger, PaidBillService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/paidbills")]
        public ActionResult<List<PaidBill>> GetPaidBills()
        {
            return _service.GetPaidBills();
        }

        [HttpPost("/api/paidbills")]
        public ActionResult<PaidBill> AddBill(PaidBill bill)
        {
            _service.AddPaidBill(bill);
            return bill;
        }

        [HttpPut("/api/paidbills/{id}")]
        public ActionResult<PaidBill> UpdatePaidBill(string id, PaidBill bill)
        {
            _service.UpdatePaidBill(id, bill);
            return bill;
        }

        [HttpDelete("/api/paidbills/{id}")]
        public ActionResult<string> DeletePaidBill(string id)
        {
            _service.DeletePaidBill(id);
            return id;
        }
    }
}