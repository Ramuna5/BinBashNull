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
    class TestBase
    {
        protected static IWebDriver Driver;

        public static ND_3_Page nD_3_Page;
        public static DemoqaTextBoxPage demoqaTextBoxPage;
        public static DemoqaSelectMenuPage demoqaSelectMenuPage;

        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            nD_3_Page = new ND_3_Page(Driver);
            demoqaTextBoxPage = new DemoqaTextBoxPage(Driver);
            demoqaSelectMenuPage = new DemoqaSelectMenuPage(Driver);
        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }

    }
}