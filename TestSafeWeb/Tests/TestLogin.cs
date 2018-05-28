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
            //Assert.IsTrue(loginpage.Login(homepage, "student@safebear.co.uk", "tester1"));
            Assert.IsTrue(loginpage.Login(homepage, param.GetEmail(), param.GetPassword()));                

            //Step 4 : Click on the Play link and access Play Page
            Assert.IsTrue(homepage.ClickPlay(playpage));

        }

        [TestMethod]
        public void TestMultiElements01()
        {
            // Step 1: check that we are on the homepage
            Assert.IsTrue(homepage.CheckPage());
            //Step 2 : click on Login Link to get to Login Home Page
            Assert.IsTrue(homepage.ClickLogin(loginpage));
            //Step 3 : sent the same text to the login and password fields
            Assert.IsTrue(loginpage.MultiElements(homepage, "student@safebear.co.uk", "tester1"));
        }

        // below won't work. Needs to add access play page etc
        // Need to add the login stage
        [TestMethod]
        public void GoToPlayPage()
        {
            //Below takes you straight to the login page
            homepage.ClickLogin(loginpage);
            //Below does the actual log in. 
            loginpage.MultiElements(homepage, param.GetEmail(), param.GetPassword());


            //Step 4 : Click on the Play link and access Play Page
            Assert.IsTrue(homepage.ClickPlay(playpage));
        }
        
    }
}
