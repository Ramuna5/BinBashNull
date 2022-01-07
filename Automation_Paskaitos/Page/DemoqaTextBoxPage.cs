using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Paskaitos.Page
{
    class DemoqaTextBoxPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/text-box";
        private IWebElement _fullNameInputField => Driver.FindElement(By.Id("userName"));
        private IWebElement _submitButton => Driver.FindElement(By.Id("submit"));
        private IWebElement _fullNameActualResult => Driver.FindElement(By.Id("name"));

        private IWebElement _popUp => Driver.FindElement(By.Id("close-fixedban"));

        public DemoqaTextBoxPage(IWebDriver webdriver) : base(webdriver) { }

        public DemoqaTextBoxPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public DemoqaTextBoxPage ClosePopUp()
        {
            GetWait(10).Until(x => _popUp.Displayed);
            _popUp.Click();

            return this;
        }

        public void InsertTextToFullNameField(string text)
        {
            _fullNameInputField.Clear();
            _fullNameInputField.SendKeys(text);
        }

        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }

        public void VerifyFullNameResult(string expectedResult)
        {
            Assert.AreEqual($"Name:{expectedResult}", _fullNameActualResult.Text, "Name is wrong!");
        }
    }
}