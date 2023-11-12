using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLPOM.Pages
{
    internal class DemoHome
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using = "search")]
        public IWebElement searchText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search']//button")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/h1")]
        public IWebElement ResultPageHeader { get; set; }


        public DemoHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }


        public string GetTitle()
        {
            return driver.Title;
        }

        public string GetPageURL()
        {
            return driver.Title;
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

    }
}
