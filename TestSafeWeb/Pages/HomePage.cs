using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace TestSafeWeb.Pages
{
    public class HomePage
    {
        //this is the driver variable where we use ChromeDriver
        private IWebDriver driver;

        //This is the HomePage constructor
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Check title on the HomePage
        public Boolean CheckPage()
        {
            return driver.Title.Contains("Home");
        }
    }
}
