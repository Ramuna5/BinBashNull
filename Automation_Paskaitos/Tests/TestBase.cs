using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Paskaitos.Page;
using Automation_Paskaitos.Tools;
using NUnit.Framework.Interfaces;
using Automation_Paskaitos.Drivers;

namespace Automation_Paskaitos.Tests
{
    class TestBase
    {
        protected static IWebDriver Driver;

        public static ND_3_Page nD_3_Page;
        public static DemoqaTextBoxPage demoqaTextBoxPage;
        public static DemoqaSelectMenuPage demoqaSelectMenuPage;
        public static BasicCalculatorPage basicCalculatorPage;
        public static SebCalculatorPage sebCalculatorPage;

        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = CustomDriver.GetChromeDriver();

            nD_3_Page = new ND_3_Page(Driver);
            demoqaTextBoxPage = new DemoqaTextBoxPage(Driver);
            demoqaSelectMenuPage = new DemoqaSelectMenuPage(Driver);
            basicCalculatorPage = new BasicCalculatorPage(Driver);
            sebCalculatorPage = new SebCalculatorPage(Driver);
        }


        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }

    }
}