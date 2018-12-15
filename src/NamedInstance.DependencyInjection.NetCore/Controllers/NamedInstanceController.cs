using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NamedInstance.DependencyInjection.NetCore.Abstracts;

namespace NamedInstance.DependencyInjection.NetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/NamedInstance")]
    public class NamedInstanceController : Controller
    {
        private readonly Func<string, IService> service;
        private readonly IService serviceA;

        public NamedInstanceController(Func<string, IService> service)
        {
            this.service = service;
            this.serviceA = service("ServiceA");
        }


        // GET: api/NamedInstance
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Service Instance Fetched : " , serviceA.ServiceName };
        }

        // GET: api/NamedInstance/5
        [HttpGet("{name}", Name = "Get")]
        public string[] Get(string name)
        {
            var serviceFetched = service(name);
            return new string[] { "Service Instance Fetched : ", serviceFetched.ServiceName };
        }
        
        // POST: api/NamedInstance
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/NamedInstance/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
