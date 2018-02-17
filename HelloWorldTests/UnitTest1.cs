using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Controllers;
using HelloWorldAPI.Models;
using HelloWorldUI.Helpers;
using System.IO;
using System;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        HelloWorldAPI.Models.Message m = new HelloWorldAPI.Models.Message() { Content = "Hello World!"};

        [TestInitialize()]
        public void TestInitialize() 
        {            
            //Delete appsettings file
            string file = System.AppContext.BaseDirectory + "appsettings.json";
            if (File.Exists(file)) 
            {
                File.Delete(file);
            }

            //Copy over new appsettings.json from HelloWordUI to test AppSettings class
            File.Copy(@"..\..\..\..\HelloWorldUI\appsettings.json", file);

        }

        [TestMethod]
        public void TestAPIGetWelcomeMessage()
        {     
            var controller = new WelcomeController();
            var response = controller.GetWelcomeMessage();
           
            Assert.IsNotNull(response);
            Assert.IsInstanceOfType(response, typeof(string));
            Assert.AreEqual("Hello World!", response);
            
        }

        [TestMethod]
        public void TestAPIDatabaseWrite()
        {     
            var controller = new DatabaseController();
            var response = controller.WriteToDatabase(m);
           
            Assert.IsNotNull(response);
            Assert.IsInstanceOfType(response, typeof(string));
            Assert.AreEqual("Hello World!", response);
            
        }

        [TestMethod]
        public void TestAPIFileWrite()
        {     
            var controller = new FileController();
            var response = controller.WriteToFile(m);   

            Assert.IsNotNull(response);           
            
        }

        [TestMethod]
        public void TestAppSettings()
        {
            AppSettings ap = new AppSettings();

            Assert.IsTrue(ap.OutputToView);
            Assert.IsTrue(ap.OutputToFile);
            Assert.IsTrue(ap.OutputToDatabase);
            
        }
    }
}
