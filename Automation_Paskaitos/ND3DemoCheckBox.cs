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
    class ND3DemoCheckBox
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            //_driver = new FirefoxDriver();
            _driver.Url = "https://demoqa.com/checkbox";
            _driver.Manage().Window.Maximize();

        }

        [OneTimeTearDown]
        public void TearDown()
        {

            _driver.Quit();
        }


        [TestCase("You have selected:", TestName = "Test Chrome CheckBox")]
        //[TestCase("Chrome", "Commands", TestName = "Test Chrome CheckBox2")]
        public static void CheckAllCheckBoxes(string expectedResult)
        {
            //IReadOnlyCollection<IWebElement> checkBoxes = _driver.FindElements(By.ClassName("rct-checkbox"));
            IWebElement checkbox = _driver.FindElement(By.ClassName("rct-checkbox"));
            checkbox.Click();
            /*
            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }*/

            IWebElement result = _driver.FindElement(By.ClassName("#display-result mt-4"));
            Assert.IsTrue(result.Text.Contains(expectedResult));


        }

        

    }
}
