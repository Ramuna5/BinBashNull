using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Paskaitos
{
    class BasicCalculator

    {
        public static ChromeDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
           // _driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
            
            _driver.Url = "https://demoqa.com/checkbox";
            IWebElement popUp = _driver.FindElement(By.CssSelector("#cookie_block > div > div > div.cookies_action > button"));

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(x => popUp.Displayed);

            popUp.Click();

            IWebElement closeButton = (IWebElement)_driver.FindElement(By.CssSelector("css=#close-fixedban > img"));
            closeButton.Click();
            
            IWebElement expandAllButton = _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg > path"));
            expandAllButton.Click();
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }
        /*
        [TestCase("25", "25.5", "50.5", TestName = "25 + 25,5 = 50,5")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "ERR", TestName = "a + b = ERR")]
        public static void TestSumBlock(string firstInputvalue, string secondInputValue, bool shouldBeCheked, string expectedResult)
        {
            IWebElement firstInput = _driver.FindElement(By.Id("number1Field"));
            IWebElement secondInput = _driver.FindElement(By.Id("number2Field"));

            firstInput.Clear();
            firstInput.SendKeys(firstInputvalue);
            secondInput.Clear();
            secondInput.SendKeys(secondInputValue);

            IWebElement calculateButton = _driver.FindElement(By.Id("calculateButton"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("numberAnswerField"));
            //Assert.AreEqual(expectedResult, actualResult.Text, "Sum is Incorrect");
            Thread.Sleep(5000);
            Assert.AreEqual(actualResult.GetAttribute("value").ToString(), "50.5");
            
        }*/

        [Test]
        public static void CheckAllCheckBoxes()
        {
            IReadOnlyCollection<IWebElement> checkBoxes = _driver.FindElements(By.ClassName("rct-checkbox"));

            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }

        }


    }
}
