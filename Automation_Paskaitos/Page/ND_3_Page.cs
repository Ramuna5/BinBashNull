using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Paskaitos.Page
{
    class ND_3_Page : BasePage
    {
        private const string PageAddress = "https://demoqa.com/checkbox";

        private IWebElement _expandAllButton => Driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        private IWebElement _homeCheckBox => Driver.FindElement(By.CssSelector("#tree-node > ol > li > span > label > span.rct-checkbox > svg"));
        private IWebElement _actualResult => Driver.FindElement(By.Id("result"));
        private IReadOnlyCollection<IWebElement> _checkBoxes => Driver.FindElements(By.ClassName("rct-text"));

        public ND_3_Page(IWebDriver webdriver) : base(webdriver) { }

        public ND_3_Page NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public ND_3_Page ClickExpandAllButton()
        {
            _expandAllButton.Click();

            return this;
        }

        public ND_3_Page DeselectAllCheckBoxes()
        {
            while (!_homeCheckBox.GetAttribute("class").Equals("rct-icon rct-icon-uncheck"))
            {
                _homeCheckBox.Click();
            }

            return this;
        }

        public ND_3_Page ClickOnTwoCheckBoxes(string firstChoice, string secondChoice)
        {
            foreach (IWebElement checkBox in _checkBoxes)
            {
                IWebElement checkboxElement = checkBox.FindElement(By.ClassName("rct-checkbox"));

                if (checkBox.Text.Equals(firstChoice))
                {
                    checkboxElement.Click();
                }
                if (checkBox.Text.Equals(secondChoice))
                {
                    checkboxElement.Click();
                }
            }

            return this;
        }

        public ND_3_Page ClickOnOneCheckBox(string choice)
        {
            foreach (IWebElement checkBox in _checkBoxes)
            {
                IWebElement checkboxElement = checkBox.FindElement(By.ClassName("rct-checkbox"));

                if (checkBox.Text.Equals(choice))
                {
                    checkboxElement.Click();
                }

            }

            return this;
        }

        public ND_3_Page VerifyResults(string expectedResult)
        {
            string testResult = _actualResult.Text;

            Assert.IsTrue(_actualResult.Text.Contains(expectedResult), "Result is Incorrect");

            return this;
        }

    }
}