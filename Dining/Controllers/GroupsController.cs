﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dining.Controllers
{
    [Route("api/[controller]")]
    public class GroupsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<object> Get()
        {

            //object[] data1 = { "value1", "value2" };
            //string[] data2 = { "value3", "value4" };

            IDictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1["id"] = "1";
            dict1["name"] = "salad";

            IDictionary<string, string> dict2 = new Dictionary<string, string>();
            dict2["id"] = "2";
            dict2["name"] = "deserts";

            IDictionary<string, string> dict3 = new Dictionary<string, string>();
            dict3["id"] = "3";
            dict3["name"] = "drinks";

            IDictionary<string, string> dict4 = new Dictionary<string, string>();
            dict4["id"] = "4";
            dict4["name"] = "main course";

            IDictionary<string, string> dict5 = new Dictionary<string, string>();
            dict5["id"] = "5";
            dict5["name"] = "snacks";


            return new object[] { dict1, dict2 ,dict3,dict4,dict5};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "groups";
           
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
