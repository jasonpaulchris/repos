using Livly.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Livly.Controllers
{
    [Produces("application/json")]
    [Route("api/OrdersAPIController")]
    public class OrdersApiController : Controller
    {
        private readonly OrdersContext _context;

        public OrdersApiController(OrdersContext context)
        {
            _context = context;
        }

        // GET: api/values   

        [HttpGet]
        [Route("Orders")]
        public IEnumerable<Orders> GetOrders()
        {
            return _context.Orders;

        }

    }
}