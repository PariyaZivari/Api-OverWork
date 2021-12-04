using ApiTest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ApiTestTest
{
    [TestClass]
    public class ManagerTest
    {
        private HttpClient _clinet;

        public ManagerTest()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _clinet = server.CreateClient();
        }
        [TestMethod]
        public void ManagerGetAllTest()
        {

        }

    }
}
