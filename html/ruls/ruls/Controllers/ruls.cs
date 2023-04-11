using Microsoft.AspNetCore.Mvc;
using ruls.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ruls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ruls : ControllerBase
    {
        private readonly LabContext _context;
        public ruls(LabContext context)
        {
            _context = context;
        }


        // GET: api/<ruls>
        [HttpGet]
        public IEnumerable<Myname> Get()
        {
            return context.Myname.ToList();
        }

        // GET api/<ruls>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ruls>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ruls>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ruls>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
