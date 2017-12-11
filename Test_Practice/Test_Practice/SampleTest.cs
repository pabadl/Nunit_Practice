using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Practice
{
    [TestFixture]
    public class SampleTest
    {
        [Test]//testapa is our test case
        public void testApp()
        {
            // TODO: Add your test code here
            //Assert.Pass("Your first passing test");
            Console.WriteLine("Testing app");

        }

        [Test]
        public void testLogin()
        {
            Console.WriteLine("Login test");
        }
    }
}
