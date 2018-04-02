using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace TestSafeWeb.Pages
{
    public class LoginPage
    {
        //this is the driver variable where we use ChromeDriver
        private IWebDriver driver;

        //Finding email and password fields on login page
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement field_emailaddress;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement field_password;

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

        public Boolean Login(HomePage homepage, String email, String password)
        {
            field_emailaddress.SendKeys(email);
            field_password.SendKeys(password);
            field_password.Submit();
            return homepage.CheckPage();

        }
    }
}
