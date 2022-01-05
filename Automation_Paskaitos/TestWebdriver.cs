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
    class TestWebdriver
    {
        [Test]
        public static void TestSumPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement InputField = driver.FindElement(By.Id("number1"));
            InputField.SendKeys("2");

            Thread.Sleep(1500);

            IWebElement InputField2 = driver.FindElement(By.Id("number2"));
            InputField2.SendKeys("2");

            Thread.Sleep(2000);

            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();

            IWebElement fullResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", fullResult.Text, "Number is good");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("number1")).Clear();
            driver.FindElement(By.Id("number2")).Clear();


            Thread.Sleep(3500);
            driver.Close();
        }

        [Test]
        public static void TestSumPage2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement InputField = driver.FindElement(By.Id("number1"));
            InputField.SendKeys("2");

            Thread.Sleep(1500);

            IWebElement InputField2 = driver.FindElement(By.Id("number2"));
            InputField2.SendKeys("2");

            Thread.Sleep(2000);

            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();

            IWebElement fullResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", fullResult.Text, "Number is good");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("number1")).Clear();
            driver.FindElement(By.Id("number2")).Clear();


            Thread.Sleep(3500);
            driver.Close();
        }
        [Test]
        public static void TestSumPage3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement InputField = driver.FindElement(By.Id("number1"));
            InputField.SendKeys("2");

            Thread.Sleep(1500);

            IWebElement InputField2 = driver.FindElement(By.Id("number2"));
            InputField2.SendKeys("2");

            Thread.Sleep(2000);

            IWebElement calcButton = driver.FindElement(By.Id("calculate"));
            calcButton.Click();

            IWebElement fullResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", fullResult.Text, "Number is good");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("number1")).Clear();
            driver.FindElement(By.Id("number2")).Clear();


            Thread.Sleep(3500);
            driver.Close();
        }




        /*
        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys("Arnas Ratkevicius");

            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();

            IWebElement fullNameResult = driver.FindElement(By.Id("name"));
            Assert.AreEqual("Name:Arnas Ratkevicius", fullNameResult.Text, "Name is wrong");

            driver.Close();

        }


        //[Test]
        //public static void TestChromeDriver()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://login.yahoo.com/";
        //    driver.Manage().Window.Maximize();
        //    driver.Quit();
        //}

        [Test]
        public static void TestfireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://login.yahoo.com/";
            driver.Manage().Window.Maximize();
            driver.Quit();
        }

        //[Test]
        //public static void TestYahooPage()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://login.yahoo.com/";

        //    IWebElement emailInputField = driver.FindElement(By.Id("login-username"));
        //    emailInputField.SendKeys("Labas@labas.lt");
        //    IWebElement submitButton = driver.FindElement(By.Id("login-signin"));
        //    submitButton.Click();
        //    driver.Close();
        //}*/



    }
} 
