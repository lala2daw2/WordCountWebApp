using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WordCountWebApp.Controllers;
using WordCountWebApp.Models;

namespace WordCountWebApp.Tests.Controllers
{
    [TestClass]
    public class WordConrollerTest
    {

        [TestMethod]
        public void TestIndexMethod()
        {
            WordController controller = new WordController();
            var result = controller.List() as ViewResult;

            
            Assert.IsNotNull(result);
            
            

        }
    }
}
