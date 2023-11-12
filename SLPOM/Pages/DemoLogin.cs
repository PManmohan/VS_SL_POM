using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLPOM.Pages
{
    internal class DemoLogin
    {

        public IWebElement UserName => driver.FindElement(By.Id("userName"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));
        public IWebElement Password => driver.FindElement(By.Id("password"));

        public DemoLogin(IWebDriver driver) {
            this.driver = driver;
            //PageFactory.InitElements(this.driver, this);
        }

        IWebDriver driver;

        /*[FindsBy(How = How.Id, Using = "userName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginButton { get; set; }
        */

        public DemoProfile Login(String UserName, String Password) { 
            this.UserName.SendKeys( UserName);
            this.Password.SendKeys(Password);
            LoginButton.Click();

            return new DemoProfile(driver);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

    }
    
}
