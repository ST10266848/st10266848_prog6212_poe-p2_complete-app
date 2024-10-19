//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CMCS_MVC_App.Models;
//using CMCS_MVC_App.Controllers.ClaimsController;
//using Microsoft.AspNetCore.Mvc;
//using Moq;

//namespace CMCS_MVC_Tests.Controller_Tests
//{
//    [TestFixture]
//    public class ClaimsControllerTests
//    {
//        private ClaimsController _controller;

//        public ClaimsControllerTests(ClaimsController controller)
//        {
//            _controller = controller;
//        }

//        [SetUp]
//        public void SetUp()
//        {
//            //Initialize the controller before each test
//            _controller = new ClaimsController();

//        }

//        [Test]
//        public void LecturerClaim_Returns_ViewResult()
//        {
//            //Act
//            var result = _controller.LecturerClaim() as ViewResult;

//            //Assert
//            Assert.IsNotNull(result); //ensure the result is not null

//            //checks for the implict name
//            Assert.IsTrue(result.ViewName == "" || result.ViewName == null);
//        }

//        [Test]
//        public void Details_ValidId_ReturnsViewResult()
//        {
//            //Arrange
//            var controller = new ClaimsController();

//            //Act
//            var result = controller.Details(1) as ViewResult;

//            //Assert 
//            Assert.IsNotNull(result);
//            Assert.AreEqual("Details", result.ViewName); //Ensure it returns the correct view for a valid ID
//        }

//    }
//}
