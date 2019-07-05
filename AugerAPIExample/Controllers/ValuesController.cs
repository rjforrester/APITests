using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AugerAPIExample.Model;

namespace AugerAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AugerContext _context;
        // GET api/values

        public ValuesController(AugerContext context)
        {
            _context = context;

            if (_context.HubItems.Count() == 0)
            {
                _context.HubItems.Add(new AugerTable { Name = "Item1", Mobile = "54343" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AugerTable>>> Get()
        {
            return await _context.HubItems.ToListAsync();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
