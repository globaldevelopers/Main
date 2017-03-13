using System.Web.Mvc;
using GlobalDevelopers.DataCaptureSolutions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GlobalDevelopers.DataCaptureSolutions.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AlternateStyle()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.AlternateStyle() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
