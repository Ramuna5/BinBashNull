using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Paskaitos
{
    //parašyti testus, ar teisingai parodo jūsų naršyklę = user agent
    class ND2
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            //_driver = new ChromeDriver();
            _driver = new FirefoxDriver();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [TestCase("Chrome", "Chrome 96 on Windows 10", TestName = "ChromeUserAgent")]

        public static void testUserAgent(string browserType, string expectedResult)
        {
            IWebElement realResult = _driver.FindElement(By.CssSelector("#primary-detection")); //#primary-detection
            Assert.AreEqual(expectedResult, realResult.Text, $"Turejo buti {expectedResult}, bet buvo {realResult}");                         //Text.Contains(expectedResult));
        }
    }
}
