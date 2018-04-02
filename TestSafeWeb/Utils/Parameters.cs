using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestSafeWeb.Utils
{
    public class Parameters
    {
        //Below commented out elements due to the get set line doing the same thing more efficiently 
        //private String url = "http://localhost:50454/";

        //Below commented out as running in headless mode.        
        private IWebDriver driver = new ChromeDriver();

        //Below line can be used instead of above to execute headless test run
        //private IWebDriver driver;

        public String GetUrl()
        {
            return url;
        }

        public String GetEmail()
        {
            return email;
        }

        public String GetPassword()
        {
            return password;
        }

        public String url { get; set; } = "http://localhost:50454/";

        public String email { get; set; } = "student@safebear.co.uk";

        public String password { get; set; } = "tester1";


        public IWebDriver GetDriver()
        {
            //below line added for headless mode
            //driver = new ChromeDriver();

            return driver;
        }

        //Below method added just for the headless mode
        //public IWebDriver GetHeadlessDriver()
        //{
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArgument("--headless");
        //    driver = new ChromeDriver(options);
        //    return driver;
        //}
    }
}
