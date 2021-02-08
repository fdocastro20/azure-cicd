using System;
using Xunit;
using ClientsService.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ClientsServiceTest
{
    public class ClientsControllerTest
    {
        private readonly ClientsController clientsController;

        public ClientsControllerTest()
        {
            clientsController = new ClientsController();
        }

        [Fact]
        public void GetClientList_ReturnsOkResponse()
        {
            var okResponse = clientsController.Get();
            Assert.IsType<OkObjectResult>(okResponse.Result);
        }

        /*[Fact]
        public void GetClient_ReturnsOkResponse()
        {
            var okResponse = clientsController.Get("2");
            Assert.IsType<OkObjectResult>(okResponse.Result);
        }*/
    }
}
