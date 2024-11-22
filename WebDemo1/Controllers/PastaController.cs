using Microsoft.AspNetCore.Mvc;

namespace WebDemo1.Controllers
{
    [Route("k1/pasta")]
    public class PastaController : BaseController
    {
        public PastaController(ILogger<BaseController> logger) : base(logger)
        {
        }

        // GET: api/<PastaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Pasta tomato meat sauce", "Pasta Cabonara scream sauce" };
        }

        // GET api/<PastaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PastaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PastaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PastaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
