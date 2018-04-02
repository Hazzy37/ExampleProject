using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestSafeWeb.Pages;
using TestSafeWeb.Utils;

namespace TestSafeWeb.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected Parameters param;
        protected HomePage homepage;
        protected LoginPage loginpage;
        protected PlayPage playpage;


        [TestInitialize]
        public void SetUp()
        {
            //Set Variable of Type Class Parameters
            param = new Parameters();

            //Set Driver variable from Paraters Get Driver method
            this.driver = param.GetDriver();

            // the this.driver needs to be added prior to these next 3 lines else driver not recognised
            homepage = new HomePage(driver);
            loginpage = new LoginPage(driver);
            playpage = new PlayPage(driver);

            

            //Set a Wait Period 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.00);

            //Set which URL to open from the Parameters Class
            driver.Navigate().GoToUrl(param.GetUrl());

            //maximize the window
            driver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void TearDown()
        {
            //Set sleep timer before quitting browser
            Thread.Sleep(2000);
            driver.Quit();
        }
       
    }
}
