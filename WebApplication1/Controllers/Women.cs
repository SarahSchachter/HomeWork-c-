using Microsoft.AspNetCore.Mvc;
 
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
     
    [Route("api/[controller]")]
    [ApiController]
    public class Women : ControllerBase
    {
        static List <Women> Womens = new List <Women> ();

        public int Id { get; private set; }
        public object Name { get; private set; }
        public object Age { get; private set; }
        public object Cors { get; private set; }

        [HttpGet]
        public List<Women> Get()
        {
            return Womens;
        }

         
        [HttpGet("{id}")]
        public Women Get(int id)
        {
            return Womens.FirstOrDefault(w=> w.Id == id);
        }

        // POST api/<Women>
        [HttpPost]
        public void Post([FromBody] Women w)
        {
            Womens.Add(w);
        }

        // PUT api/<Women>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Women w )
        {
            int index=Womens.FindIndex(w=>w.Id==id);
            Womens[index].Name = w.Name;
            Womens[index].Age = w.Age;
            Womens[index].Cors = w.Cors;
         }

        // DELETE api/<Women>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index=Womens.FindIndex(w=>w.Id==id);
            Womens.RemoveAt(index);
        }
    }
}
