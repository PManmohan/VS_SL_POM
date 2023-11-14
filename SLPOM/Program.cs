using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SLPOM.Factory;
using SLPOM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SLPOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        IWebDriver driver = null;
        Home homePage = null;

        [SetUp]
        public void initialize()
        {
            DriverFactory df=new DriverFactory();
            driver = df.InitDriver("Chrome");
            Console.WriteLine("Initialize driver");
            //driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            //PropertiesCollection.driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            

        }

        [Test]
        public void VerifyURL()
        {
            var expectedURL= "demoqa.com/login";
            Home homePage = new Home(driver);
            //
            var actualURL = homePage.GetPageURL();
            Console.WriteLine(actualURL);
            Assert.AreSame(actualURL,  expectedURL);
        }

        [Test]
        public void Demo_Login()
        {
            Console.WriteLine("Demo login");
            DemoLogin demoLogin = new DemoLogin(driver);
            Console.WriteLine("Demo login"+demoLogin.GetTitle());
            demoLogin.Login("Patil", "Aaaa@123");

        }

        [Test]
        public void VerifyTitle()
        {
            Console.WriteLine("ExecuteTest");
            var expectedURL = "DEMOQA";
            Console.WriteLine("-changes made here");

            Home homePage = new Home(driver);
            var actualURL = homePage.GetTitle();
            Console.WriteLine(actualURL);
            Assert.AreEqual(actualURL, expectedURL);
            //homePage.Login("Patil", "Aaaa@123");
            //UIOperations.EnterText("firstName", "abc", PropertyType.Id);
            //UIOperations.Click("Gender", PropertyType.Name);
            //UIOperations.Select("state", "NCR", "id");

            //var q = driver.FindElement(By.Id("APjFqb"));
            //q.SendKeys("How should I get it?");

        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
