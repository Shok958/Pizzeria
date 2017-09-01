﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaLogin;
using PruebaLogin.Controllers;

namespace PruebaLogin.Tests.Controllers
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
        public void RegisterGivenNull()
        {
            // Arrange
            var controller = new AccountController();
        
            // Act
            var result = controller.Login("") as ViewResult;
            Assert.IsNotNull(result);
        }

    }
}