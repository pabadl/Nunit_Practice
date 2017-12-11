using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Practice
{
    [TestFixture]
    public class TestClass
    {
        

        [SetUp]//before executing every test case
        public void openBrowser()
        {
           
            Console.WriteLine("Testing sending emails");
        }

        [Test]
        public void testSendMail()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://facebook.com";

            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("email")).SendKeys("jpabadl96@hotmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("jpablojuan19" + Keys.Enter);
            Console.WriteLine("Testing sending emails");

        }

        [TearDown]//after executing every test case
        public void closeBrowser()
        {
            Console.WriteLine("Closing browser");
        }
    }
}
