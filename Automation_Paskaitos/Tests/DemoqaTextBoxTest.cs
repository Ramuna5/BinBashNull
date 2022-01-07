using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Paskaitos.Page;

namespace Automation_Paskaitos.Tests
{
    class DemoqaTextBoxTest : TestBase
    {

        [Test]
        public static void FullNameTextBoxTest()
        {
            string text = "Test";

            demoqaTextBoxPage.NavigateToDefaultPage();
            demoqaTextBoxPage.ClosePopUp();
            demoqaTextBoxPage.InsertTextToFullNameField(text);
            demoqaTextBoxPage.ClickSubmitButton();
            demoqaTextBoxPage.VerifyFullNameResult(text);
        }

    }
}