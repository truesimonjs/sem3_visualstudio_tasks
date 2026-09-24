using Microsoft.AspNetCore.Mvc;
using Rest_Excercise1_attempt2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest_Excercise1_attempt2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AktieController : ControllerBase
    {
        private AktieRepository repo;
        public AktieController(AktieRepository repo)
        {
            this.repo = repo;
        }
        // GET: api/<AktieController>
        [HttpGet]
        public IEnumerable<Aktie> Get()
        {
            return repo.GetAll();
        }

        // GET api/<AktieController>/5
        [HttpGet("{id}")]
        public Aktie Get(int id)
        {
            return repo.GetById(id);
        }

        // POST api/<AktieController>
        [HttpPost]
        public Aktie Post([FromBody] Aktie value)
        {
            return repo.add(value);
        }

        // PUT api/<AktieController>/5
        [HttpPut("{id}")]
        public Aktie Put(int id, [FromBody] Aktie value)
        {
            return repo.Update(id, value);
        }

        // DELETE api/<AktieController>/5
        [HttpDelete("{id}")]
        public Aktie Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
