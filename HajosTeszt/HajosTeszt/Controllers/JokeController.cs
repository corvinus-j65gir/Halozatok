using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET: api/jokes
        [HttpGet]
        public IEnumerable<JokeModels.Joke> Get()
        {
            JokeModels.FunnyDatabaseContext context = new JokeModels.FunnyDatabaseContext();
            return context.Jokes.ToList();
        }

        // GET api/jokes/5
        [HttpGet("{id}")]
        public JokeModels.Joke Get(int id)
        {
            JokeModels.FunnyDatabaseContext context = new JokeModels.FunnyDatabaseContext();
            var keresettVicc = (from x in context.Jokes
                                where x.JokeSk == id
                                select x).FirstOrDefault();
            return keresettVicc;
        }

        // POST api/jokes
        [HttpPost]
        public void Post([FromBody] JokeModels.Joke újVicc)
        {
            JokeModels.FunnyDatabaseContext context = new JokeModels.FunnyDatabaseContext();
            context.Jokes.Add(újVicc);
            context.SaveChanges();
        }

        // PUT api/<JokeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/jokes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            JokeModels.FunnyDatabaseContext context = new JokeModels.FunnyDatabaseContext();
            var törlendőVicc = (from x in context.Jokes
                                where x.JokeSk == id
                                select x).FirstOrDefault();
            context.Remove(törlendőVicc);
        }
    }
}
