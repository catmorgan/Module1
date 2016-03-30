using Microsoft.AspNet.Mvc;
using Module1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Module1.Tests
{
    public class HomeControllerTests
    {

        [Fact()]
        public void HomeControllerIndexReturnsView()
        {
            //assembly
            var controller = new HomeController();
            //act
            var result = controller.Index() as ViewResult;
            //assert
            Assert.NotNull(result);
        }
    }
}
