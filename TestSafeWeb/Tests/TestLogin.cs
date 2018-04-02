using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSafeWeb.Tests;

namespace TestSafeWeb
{
    /// <summary>
    /// These are the steps run the main body of the test 
    /// </summary>
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

            //Step 3 : Login and confirm homepage is displayed
            Assert.IsTrue(loginpage.Login(homepage, "student@safebear.co.uk", "tester1"));

            //Step 4 : Click on the Play link and access Play Page
            Assert.IsTrue(homepage.ClickPlay(playpage));

        }
    }
}
