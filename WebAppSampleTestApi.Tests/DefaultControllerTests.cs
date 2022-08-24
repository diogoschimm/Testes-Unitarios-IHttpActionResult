using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppSampleTestApi.Controllers;

namespace WebAppSampleTestApi.Tests
{
    [TestClass]
    public class DefaultControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new DefaultController();
            dynamic result = controller.Get("10");
            dynamic response = result.Content;

            Assert.AreEqual(true, response.Success);
            Assert.AreEqual("10", response.Data);
        }
    }
}
