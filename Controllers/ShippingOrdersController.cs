using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShippingOrders.Data;
using ShippingOrders.Models;

namespace ShippingOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingOrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ShippingOrdersController(ApplicationDbContext db)
        {       

            _db =db;
        }

        [HttpGet("private")]
        [Authorize]
        public IActionResult Private()
        {
            return Ok(new
            {
                Message = "Hello from a private endpoint! You need to be authenticated to see this."
            });
        }

        [HttpGet("private-scoped")]
        [Authorize(Roles="read:messages")]
        public IActionResult Scoped()
        {
            return Ok(new
            {
                Message = "Hello from a private endpoint! You need to be authenticated and have a scope of read:messages to see this."
            });
        }

        [HttpGet]
        public async Task<List<Orders>> GetShippingOrders()
        {
            var orders = await _db.Orders.ToListAsync();
            if(orders.Count ==0)
            {
                return null;
            }
            return orders;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Orders>> GetShippingOrder(string Id)
        {
            var order = await _db.Orders.FindAsync(Id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }
        [HttpPost]
        public async Task<ActionResult<Orders>> CreateShippingOrder(Orders o)
        {
            _db.Orders.Add(o);
            await _db.SaveChangesAsync();
            return CreatedAtAction("GetShippingOrder", new { Id = o.ShipperOrderId },o);
        }
    }
}
