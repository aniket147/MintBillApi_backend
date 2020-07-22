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
    public class UpcomingBillController : ControllerBase
    {
        public ILogger _logger;
        public UpcomingBillService _service;

        public UpcomingBillController(ILogger<UpcomingBillController> logger, UpcomingBillService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/upcomingbills")]
        public ActionResult<List<UpcomingBill>> GetUpcomingBills()
        {
            return _service.GetUpcomingBills();
        }

        [HttpPost("/api/upcomingbills")]
        public ActionResult<UpcomingBill> AddUpcomingBill(UpcomingBill bill)
        {
            _service.AddUpcomingBill(bill);
            return bill;
        }

        [HttpPut("/api/upcomingbills/{id}")]
        public ActionResult<UpcomingBill> UpdateUpcomingBill(string id, UpcomingBill bill)
        {
            _service.UpdateUpcomingBill(id, bill);
            return bill;
        }

        [HttpDelete("/api/upcomingbills/{id}")]
        public ActionResult<string> DeleteUpcomingBill(string id)
        {
            _service.DeleteUpcomingBill(id);
            return id;
        }
    }
}