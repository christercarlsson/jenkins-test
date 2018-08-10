using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTest.Controllers;

namespace JenkinsTest.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void ShouldReturnView()
        {
            HomeController hc = new HomeController();

            var p = hc.Index();

            Assert.IsNotNull(p);
        }
    }
}
