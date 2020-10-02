using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using opgave4;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rest.Controllers
{
    [Route("fanoutput")]
    [ApiController]
    public class FanController : ControllerBase
    {

        private static readonly List<FanOut> fanOuts = new List<FanOut>()
        {
            new FanOut(1, "stue", 24.3, 65.02),
            new FanOut(2, "værelseet", 24.2, 52.53),
            new FanOut(3, "bryggers", 24.3, 79.02),
            new FanOut(4, "toilet", 15.6, 50.23),
            new FanOut(5, "værelseto", 24.3, 79.02)
        };

        // GET: api/<FanController>
        [HttpGet]
        public IEnumerable<FanOut> Get()
        {
            return fanOuts;
        }

        // GET api/<FanController>/5
        [HttpGet("{id}")]
        public FanOut Get(int id)
        {
            return fanOuts.Find(i => i.Id == id);
        }

        // POST api/<FanController>
        [HttpPost]
        public void Post([FromBody] FanOut value)
        {
            fanOuts.Add(value);
        }

        // PUT api/<FanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOut value)
        {
            FanOut fanOut = Get(id);
            if (fanOut != null)
            {
                fanOut.Name = value.Name;
                fanOut.Temp = value.Temp;
                fanOut.Fugt = value.Fugt;
            }
        }

        // DELETE api/<FanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FanOut fanOut = Get(id);
            fanOuts.Remove(fanOut);
        }
    }
}
