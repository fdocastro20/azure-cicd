using System;
using Xunit;
using InventoryService.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace InventoryServiceTest
{
    public class InventoryControllerTest
    {
        readonly InventoryController inventoryController;

        public InventoryControllerTest()
        {
            inventoryController = new InventoryController();
        }
        
        [Fact]
        public void GetInventoryList_ReturnsOkResponse()
        {
            var okResponse = inventoryController.Get();
            Assert.IsType<OkObjectResult>(okResponse.Result);
        }

        [Fact]
        public void GetInventoryItem_ReturnsOkResponse()
        {
            var okResponse = inventoryController.Get("2");
            Assert.IsType<OkObjectResult>(okResponse.Result);
        }
    }
}
