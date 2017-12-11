using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Practice
{
    [TestFixture]
    public class YahooTest
    {
        [Test]
        public void testRecieveMail()
        {
            Console.WriteLine("Testing recieving emails");
            try
            {


                Assert.AreEqual("hola", "holaa");
                Assert.IsTrue(4 < 2, "error");
            }
            catch(Exception e)
            {
                Console.WriteLine("caught the error");
            }
          }

        [Test]
        public void testSendMail()
        {
            Console.WriteLine("Testing sending emails");

        }

        [SetUp]//before executing every test case
        public void openBrowser()
        {
            Console.WriteLine("Opening browser");
        }

        [TearDown]//after executing every test case
        public void closeBrowser()
        {
            Console.WriteLine("Closing browser");
        }
             
    }
}
