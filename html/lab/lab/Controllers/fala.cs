using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class fala : ControllerBase
    {
        // GET: api/<fala>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<fala>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<fala>
        [HttpPost]
        public void Post([FromBody] string value)Scaffold-DbContext "Server=192.168.1.70;Database=lab;Trusted_Connection=True;User ID=lab;Password=a123" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
        {
        }

        // PUT api/<fala>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<fala>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
