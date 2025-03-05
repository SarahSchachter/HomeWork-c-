using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WomenController : ControllerBase
    {
        static List<Women> Womens = new List<Women>()
        { 
            new Women() { Id = 1,Name="Tali",Age=19,Cors="photo"},
            new Women() { Id = 2,Name="Sarah",Age=19,Cors="photo"},
            new Women() { Id = 3,Name="Shoshana",Age=19,Cors="photo"}

        };


        [HttpGet]
        public List<Women> Get()
        {
            return Womens;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Women women = Womens.First(w=> w.Id==id);
                return Ok(women);
            }

            catch (Exception ex) 
            {
            return NotFound(ex.Message);

                 }

        }

        // POST api/<Women>
        [HttpPost]
        public void Post([FromBody] Women w)
        {
            Womens.Add(w);
        }

        // POST api/<Women>
        [HttpPost("createDataSave/{path}")]
        public IActionResult Post(string path)
        {
            try 
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (Women w in Womens)
                    {
                        sw.WriteLine("women" + w.Id);
                        sw.WriteLine(w.Name);
                        sw.WriteLine(w.Age);
                        sw.WriteLine(w.Cors);

                    }
                    return Ok("succes");
                }
            }

            catch(Exception ex)
            {
                return BadRequest(ex);
            }
         
         }

        // PUT api/<Women>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Women w)
        {
            int index = Womens.FindIndex(w => w.Id == id);
            Womens[index].Name = w.Name;
            Womens[index].Age = w.Age;
            Womens[index].Cors = w.Cors;
        }

        // DELETE api/<Women>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                int index = Womens.FindIndex(w => w.Id == id);
                Womens.RemoveAt(index);
            }

            catch (Exception ex)
            {
                Console.WriteLine("cant");

            }



        
        }



    }
}
