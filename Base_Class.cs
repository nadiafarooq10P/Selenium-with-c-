using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_Training
{
    public class Base_Class
    {
        public IWebDriver driver = new ChromeDriver();

        // Initialize Driver
        [TestInitialize]
        public void WebdriverInitialization1()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        //Closing Driver
        [TestCleanup]
        public void ClosingBrowser2()
        {
            driver.Close();
        }

    }
}
