using DemoDotNetProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoDotNetProjectTest
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            HomeController controller = new HomeController();
            string expected = "Koustav Majumder";

            //Act
            var result = controller.Index() as ViewResult;
            var actual = (string)result.ViewData["Name"];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
