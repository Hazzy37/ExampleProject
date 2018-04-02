using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSafeWeb.Utils
{
    public class Parameters
    {
        //Below commented out elements due to the get set line doing the same thing more efficiently 
        //private String url = "http://localhost:50454/";
        private IWebDriver driver = new ChromeDriver();

        public String GetUrl()
        {
            return url;
        }


        public String url { get; set; } = "http://localhost:50454/";
        
        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
