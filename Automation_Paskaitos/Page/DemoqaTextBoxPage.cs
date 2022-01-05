using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Paskaitos
{
    class DemoqaTextBoxPage
    {
        private static IWebDriver _driver;

        private IWebElement _fulNameInputField => _driver.FindElement(By.Id("userName"));
        private IWebElement _submitButton => _driver.FindElement(By.Id("submit"));
        private IWebElement _fullNameActualResult => _driver.FindElement(By.Id("name"));

        public DemoqaTextBoxPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void InsertTextToFullNameField(string text)
        {
            _fulNameInputField.Clear();
            _fulNameInputField.SendKeys(text);
        }

        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }
        public void VerifyFullNameResult(string expectedResult)
        {
            Assert.AreEqual($"Name:{expectedResult}", _fullNameActualResult.Text, "Name is wrong!");
        }
        

















        /*private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demoqa.com/checkbox";

            IWebElement popUp = _driver.FindElement(By.Id("close-fixedban"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(x => popUp.Displayed);
            popUp.Click();

            IWebElement expandAllButton = _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
            expandAllButton.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void CheckAllCheckBoxes()
        {
            IReadOnlyCollection<IWebElement> checkBoxes = _driver.FindElements(By.ClassName("rct-checkbox"));

            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }
        }*/


    }
}