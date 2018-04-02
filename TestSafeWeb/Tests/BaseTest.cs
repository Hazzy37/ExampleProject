using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestSafeWeb.Utils;

namespace TestSafeWeb.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected Parameters param;

        [TestInitialize]
        public void SetUp()
        {
            //Set Variable of Type Class Parameters
            param = new Parameters();

            //Set Driver variable from Paraters Get Driver method
            this.driver = param.GetDriver();

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
