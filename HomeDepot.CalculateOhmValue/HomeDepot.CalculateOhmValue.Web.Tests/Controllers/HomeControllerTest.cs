using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeDepot.CalculateOhmValue.Web;
using HomeDepot.CalculateOhmValue.Web.Controllers;
using System.ComponentModel.DataAnnotations;
using HomeDepot.CalculateOhmValue.Web.Models;

namespace HomeDepot.CalculateOhmValue.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
       public void ThreeBand2R1BMult10Returns210()
        {
            // Arrange
            HomeController testController = new HomeController();
            BandColorModel bandModel = new BandColorModel();
            bandModel.BandAColor = "red";
            bandModel.BandBColor = "brown";
            bandModel.BandCColor = null;
            bandModel.BandDColor = "brown";

            bandModel.Band = 3;

            // Act
            var result = testController.CalculateOhm(bandModel) as PartialViewResult;


            // Assert
            Assert.AreEqual(210, result.Model);
        }

        [TestMethod]
        public void FourBand4Y5G6BlueMul100Return45600()
        {
            //Arrange
            HomeController homecontroller = new HomeController();
            BandColorModel bandmodel = new BandColorModel();
            bandmodel.BandAColor = "yellow";
            bandmodel.BandBColor = "green";
            bandmodel.BandCColor = "blue";
            bandmodel.BandDColor = "red";

            bandmodel.Band = 4;
                       
            //Act
            var result = homecontroller.CalculateOhm(bandmodel) as PartialViewResult;
            
            //Assert
            Assert.AreEqual(45600, result.Model);
        }

        [TestMethod]
        public void ThreeBand4YnullMul100ReturnsException()
        {
            //Arrange
            HomeController homecontroller = new HomeController();
            BandColorModel bandmodel = new BandColorModel();
            bandmodel.BandAColor = "yellow";
            bandmodel.BandBColor = null;
            bandmodel.BandCColor = null;
            bandmodel.BandDColor = "red";

            bandmodel.Band = 3;

            //Act
            var result = homecontroller.CalculateOhm(bandmodel) as PartialViewResult;

            //Assert
            var model = result.ViewData.ModelState["bandBColor"];
            Assert.AreEqual("invalid bandBColor color", model.Errors[0].ErrorMessage);
        }

        [TestMethod]
        public void FourBand4YnullMul100ReturnsException()
        {
            //Arrange
            HomeController homecontroller = new HomeController();
            BandColorModel bandmodel = new BandColorModel();
            bandmodel.BandAColor = "yellow";
            bandmodel.BandBColor = null;
            bandmodel.BandCColor = null;
            bandmodel.BandDColor = "red";

            bandmodel.Band = 4;

            //Act
            var result = homecontroller.CalculateOhm(bandmodel) as PartialViewResult;

            //Assert
            Assert.AreEqual(2, result.ViewData.ModelState.Count);
        }
    }
}
