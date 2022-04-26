using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRCCFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderPizzaController : ControllerBase
    {
       
        

        private readonly ILogger<OrderPizzaController> _logger;

        private IUnitOfWork Uow;

        public OrderPizzaController(ILogger<OrderPizzaController> logger, IUnitOfWork _uow)
        {
            _logger = logger;
            Uow = _uow;
        }

        [HttpPost]
        [Route("submitOrder")]
        public bool SubmitOrder(CustomerOrder customerOrder)
        {
           return Uow.AddOrder(customerOrder);
            
        }

    }
}
