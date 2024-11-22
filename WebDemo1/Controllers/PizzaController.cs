using Microsoft.AspNetCore.Mvc;

namespace WebDemo1.Controllers
{
    [Route("k1/pizza")]
    public class PizzaController : BaseController
    {
        public PizzaController(ILogger<BaseController> logger) : base(logger)
        {
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return new string[] { "Pizza Basic Pepperoni", "Pizza Hawaii (demon of pinapple)" };
        }
    }
}
