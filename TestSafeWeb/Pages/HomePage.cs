using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace TestSafeWeb.Pages
{
    public class HomePage
    {
        //this is the driver variable where we use ChromeDriver
        private IWebDriver driver;

        //Find login link using link text
        [FindsBy(How = How.LinkText, Using = "Log in")]
        private IWebElement link_login;

        //Finding the Play button
        [FindsBy(How = How.LinkText, Using = "Play")]
        private IWebElement link_play;

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

        //method to click login link
        public Boolean ClickLogin(LoginPage loginpage)
        {
            link_login.Click();
            return loginpage.CheckPage();
        }

        //method to click Play link
        public Boolean ClickPlay(PlayPage playpage)
        {
            link_play.Click();
            return playpage.CheckPage();
        }
    }
}
