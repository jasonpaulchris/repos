using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryDevilApi.Controllers
{
    [Route("api/[controller]")]
    [DisableCors]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/orders
        [HttpGet]
        public IEnumerable<Orders> Gettblorders()
        {
            return _context.tblorders;
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order = await _context.tblorders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }



        private bool OrderExists(int id)
        {
            return _context.tblorders.Any(e => e.Id == id);
        }
    }
}
