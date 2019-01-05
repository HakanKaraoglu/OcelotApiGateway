using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrdersApi.Models;

namespace OrdersApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values
        [HttpGet,Route("")]
        public IActionResult GetOrders()
        {
            var order1=new Order(1,100);
            var order2=new Order(2,200);
            return Ok(new List<Order>{order1,order2});
        }

        
    }
}
