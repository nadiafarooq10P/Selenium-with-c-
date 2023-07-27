using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Reflection;
using static System.Net.WebRequestMethods;
using System;
using System.Threading;

namespace SeleniumBatch3
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Assignment2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://10pearlsuniversity.org/");
            Console.WriteLine(driver.Title);
            string s = driver.Title.ToString();
            if (s == "Home - 10PEARLS University")
            {

                Console.WriteLine("Title of the Page: Home - 10PEARLS University");
            }

            else
            {
                Console.WriteLine("Failed");

            }

            driver.Navigate().GoToUrl("https://saucedemo.com/");
            driver.Navigate().Back();
            Console.WriteLine(driver.Url);
            driver.Navigate().Refresh();
            driver.Close();

        }
    }
}

