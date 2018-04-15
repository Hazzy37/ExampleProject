using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

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

        [FindsBy(How = How.XPath, Using = "//input[@id=\"email\" or @id=\"password\"]")]
        private IList<IWebElement> fields_login;

        //This is the LoginPage constructor that forces us to pass through the driver object 
        // and also sets up the WebElements
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

        //This is where we use the liest we created earlier to log in
        // Each element in the list is identified by an index
        public Boolean MultiElements(HomePage homepage, String email, String password)
        {
            //this is the email field
            fields_login[0].SendKeys(email);
            // password field
            fields_login[1].SendKeys(password);
            fields_login[1].Submit();
            return homepage.CheckPage();

      
        }
    }
}
