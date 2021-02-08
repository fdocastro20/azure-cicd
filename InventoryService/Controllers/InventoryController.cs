using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InventoryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly Dictionary<string, string> inventoryList;

        public InventoryController()
        {
            inventoryList = new Dictionary<string, string>();
            inventoryList.Add("1", "Ipad Pro");
            inventoryList.Add("2", "Moto G7");
            inventoryList.Add("3", "Huawei P30");
            inventoryList.Add("4", "OnePlus 7 Pro");
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return NotFound();
            return Ok(inventoryList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            if (inventoryList.ContainsKey(id))
                return Ok(inventoryList[id]);
            else
                return NotFound("Inventory item with id:" + id + " was not found");
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
