using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;

namespace SLPOM.Pages
{
    internal class Home
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using="search")]
        public IWebElement searchText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search']//button")]
        public IWebElement searchButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/h1")]
        public IWebElement ResultPageHeader { get; set; }



        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginButton { get; set; }


        public Home(IWebDriver driver) { 
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }


        public string GetTitle()
        {
            return driver.Title;
        }

        public string GetPageURL()
        {
            return driver.Url;
        }

        public string Search(String serach)
        {
            searchText.SendKeys(serach);
            searchButton.Click();

            if (ResultPageHeader.Displayed)
                System.Console.WriteLine("result deisplayed");
            else
                System.Console.WriteLine("result deisplayed");


            return driver.Title;
        }

        public DemoProfile Login(String UserName, String Password)
        {
            this.UserName.SendKeys(UserName);
            this.Password.SendKeys(Password);
            LoginButton.Click();

            return new DemoProfile(driver);
        }
    }
}
