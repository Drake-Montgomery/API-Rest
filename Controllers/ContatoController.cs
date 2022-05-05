using Agenda.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Route("api/Contato")]
    [ApiController]
    public class ContatoController : Controller
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        //GET: api/<ContatoController>
        [HttpGet]
        public async Task<IEnumerable<Contato>> GetAllAsync()
        {
            var contatos = await _contatoService.ListAsync();
            return contatos;
        }

        // GET: api/<ContatoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ContatoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContatoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContatoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContatoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
