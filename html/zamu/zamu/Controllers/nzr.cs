using Microsoft.AspNetCore.Mvc;
using zamu.Models;
using Microsoft.EntityFrameworkCore;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zamu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class nzr : ControllerBase
    {
        private readonly LabContext labContext;

        public nzr(LabContext labContext)
        {
            this.labContext = labContext;
        }
        // GET: api/<nzr>
        [HttpGet]
        public IEnumerable<Myname> Get()
        {
             var result = labContext.Mynames;
              return result;
            //var result = from a in labContext.Mynames
                      //   where a.State == "1"
                      //   select a;
            //return result;
        }

        // GET api/<trew>/5
        [HttpGet("{id}")]
        public AcceptedResult Get(string id)
        {
            var result = (from a in labContext.Mynames
                          where a.State == "id"
                          select a).SingleOrDefault();
            
            return  result;
        }

        // POST api/<nzr>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<nzr>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<nzr>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
