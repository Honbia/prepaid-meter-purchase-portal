// File: Controllers/MeterController.cs
using Microsoft.AspNetCore.Mvc;
using ikejaAPI.Models;
using ikejaAPI.Services;

namespace IkejaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeterController : ControllerBase
    {
        private readonly PurchaseMeter _purchaseService = new();

        [HttpPost]
        public IActionResult Save([FromBody] MeterClass meter)
        {
            _purchaseService.SavePurchaseToFile(meter);
            return Ok("Saved");
        }

        [HttpGet]
        public ActionResult<MeterClass> Get()
        {
            var meter = _purchaseService.GetPurchase();
            if (meter == null) return NotFound("No data found");
            return Ok(meter);
        }
    }
}