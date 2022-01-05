using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Paskaitos
{
    class FirefoxWebDriver
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            //_driver = new FirefoxDriver();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            _driver.Manage().Window.Maximize();

        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public static void TestFirefoxDriver()
        {

            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "https://www.mozilla.org/en-US/";
            //Thread.Sleep(1500);
            //driver.Quit();
        }
    }
}
