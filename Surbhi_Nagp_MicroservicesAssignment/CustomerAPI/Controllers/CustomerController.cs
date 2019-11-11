using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET api/Customer
        [HttpGet]
        public string Get()
        {
            return "I am customer API";
        }

        // GET api/Customer/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Customer
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
