using DesignPatterns.Behavioral.Strategy.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FactoryMethodController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        //Inject the service into the controllers constructor
        public FactoryMethodController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        //Never implement logic inside the controller's methods
        //We use the service to implement the business llogic
        [HttpPost("pay")]
        public async Task<IActionResult> Pay(PaymentRequest request)
        {
            return Ok(await _paymentService.Pay(request));
        }
    }
}