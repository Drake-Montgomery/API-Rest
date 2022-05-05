using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class CleinteController : Controller
    {
        // GET: api/<CleinteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CleinteController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/<CleinteController>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            return Ok();
        }

        // PUT api/<CleinteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CleinteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Delete succeeded";
        }
    }
}
