using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace TestSafeWeb.Pages
{
    public class LoginPage
    {
        //this is the driver variable where we use ChromeDriver
        private IWebDriver driver;

        //This is the LoginPage constructor
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Check title on the LoginPage
        public Boolean CheckPage()
        {
            return driver.Title.Contains("Log in");
        }
    }
}
