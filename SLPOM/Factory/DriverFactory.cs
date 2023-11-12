using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLPOM.Factory
{
    internal class DriverFactory
    {
        public IWebDriver driver=null;
        public IWebDriver InitDriver(String BrowserName,String URL= "https://demoqa.com/login")
        {
            System.Console.WriteLine("BrowserName is " + BrowserName);
            

            switch(BrowserName.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(BrowserName);
            }

            if(URL!=String.Empty)
                driver.Navigate().GoToUrl(URL);
            return driver;
        }
    }

    
}
