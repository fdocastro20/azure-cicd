using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClientsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly Dictionary<string, string> clientList;

        public ClientsController()
        {
            clientList = new Dictionary<string, string>();
            clientList.Add("1", "Alfredo Martínez");
            clientList.Add("2", "Samantha Rojas");
            clientList.Add("3", "Verónica Sanchez");
            clientList.Add("4", "Pablo Solano");
            clientList.Add("5", "Bartolito");
        }

        // GET api/clients
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return NotFound();
            return Ok(clientList);
        }

        // GET api/clients/8
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            throw new NotImplementedException("This method is not implemented");
            /*if (clientList.ContainsKey(id))
                return Ok(clientList[id]);
            else
                return NotFound("Client with id:" + id + " was not found");*/
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
