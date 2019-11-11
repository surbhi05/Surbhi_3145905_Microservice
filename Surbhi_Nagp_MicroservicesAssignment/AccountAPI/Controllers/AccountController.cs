﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        // GET api/account
        [HttpGet]
        public string Get()
        {
            return "I am account API";
        }

        // GET api/account/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
