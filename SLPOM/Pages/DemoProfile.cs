using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLPOM.Pages
{
    internal class DemoProfile
    {
        [FindsBy(How = How.Id, Using ="userName-value")]
        public IWebElement UserName { get; set; }

        IWebDriver Driver { get; set; }

        public DemoProfile(IWebDriver driver)
        {
            this.Driver = driver;
        }


    }
}
