using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/beadando")]
    [ApiController]
    public class BeadandoController : ControllerBase
    {
        // GET: api/Diaks
        [HttpGet]
        public IEnumerable<BeadandoM.Diak> Get()
        {
            BeadandoM.BeadandoContext context = new BeadandoM.BeadandoContext();
            return context.Diaks.ToList();
        }

        // GET api/Diaks/5
        [HttpGet("{id}")]
        public BeadandoM.Diak Get(int id)
        {
            BeadandoM.BeadandoContext context = new BeadandoM.BeadandoContext();
            var keresettDiak = (from x in context.Diaks
                                where x.DiakAz == id
                                select x).FirstOrDefault();
            return keresettDiak;
        }

        // POST api/Diaks
        [HttpPost]
        public void Post([FromBody] BeadandoM.Diak ujDiak)
        {
            BeadandoM.BeadandoContext context = new BeadandoM.BeadandoContext();
            context.Diaks.Add(ujDiak);
            context.SaveChanges();
        }

        // PUT api/<BeadandoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Diaks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BeadandoM.BeadandoContext context = new BeadandoM.BeadandoContext();
            var torlendoDiak = (from x in context.Diaks
                                where x.DiakAz == id
                                select x).FirstOrDefault();
            context.Remove(torlendoDiak);
            context.SaveChanges();
        }
    }
}
