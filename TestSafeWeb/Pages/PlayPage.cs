using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace TestSafeWeb.Pages
{
    public class PlayPage
    {
        //this is the driver variable where we use ChromeDriver
        private IWebDriver driver;

        //This is the PlayPage constructor
        public PlayPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Check title on the PlayPage
        public Boolean CheckPage()
        {
            return driver.Title.Contains("Play Page");
        }
        
    }
}
