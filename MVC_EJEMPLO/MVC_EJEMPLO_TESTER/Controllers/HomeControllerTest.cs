using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_EJEMPLO.Controllers;
using NUnit.Framework;

namespace MVC_EJEMPLO_TESTER.Controllers
{
    public class HomeControllerTest
    {
        [Test]
        public void IndexTest()
        {
            var controller = new HomeController();
            var view = controller.Index();
            Assert.IsNotNull(view);
        }

        [Test]
        public void PrivacyTest()
        {
            var controller = new HomeController();
            var view = controller.Privacy();
            Assert.IsNotNull(view);
        }
    }
}
