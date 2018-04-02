using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSafeWeb.Tests;

namespace TestSafeWeb
{
    [TestClass]
    public class TestLogin:BaseTest
    {
        [TestMethod]
        public void TestLogin01()
        {
            //Initial test below
            //Assert.IsTrue(true);

            //Step 1 : Check on Home Page
            Assert.IsTrue(homepage.CheckPage());

            //Step 2 : Click on Login to get to Login page
            Assert.IsTrue(homepage.ClickLogin(loginpage));
        }
    }
}
