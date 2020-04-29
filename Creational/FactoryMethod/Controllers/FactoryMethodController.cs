using DesignPatterns.Creational.FactoryMethod.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FactoryMethodController : ControllerBase
    {
        private readonly ICreditCardService _creditCardService;

        //Inject the service into the controllers constructor
        public FactoryMethodController(ICreditCardService paymentService)
        {
            _creditCardService = paymentService;
        }

        //Never implement logic inside the controller's methods
        //We use the service to implement the business llogic
        [HttpPost("CreateCreditCard")]
        public async Task<IActionResult> CreateCreditCard(CreditCardRequest request)
        {
            return Ok(await _creditCardService.CreateCreditCard(request));
        }
    }
}