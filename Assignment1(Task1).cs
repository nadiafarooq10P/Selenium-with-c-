using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Reflection;
using static System.Net.WebRequestMethods;

namespace SeleniumBatch3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginValidation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
            Assert.IsTrue(driver.Url.Equals("https://practicetestautomation.com/practice-test-login/"));

            //Assert.AreEqual(driver.Url.Contains("https://10pearlsuniversity.org/"), "Passed")

            driver.FindElement(By.CssSelector("input[name='username']")).SendKeys("student");
            driver.FindElement(By.CssSelector("input[name='password']")).SendKeys("Password123");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
            // Assert.AreEqual(driver.Url.Contains("https://practicetestautomation.com/logged-in-successfully/"), "https://practicetestautomation.com/logged-in-successfully/");
            Thread.Sleep(2000);

            if (driver.Url.Contains("https://practicetestautomation.com/logged-in-successfully/"))
            {
                Console.WriteLine("Login successfully");
            }

            else
            {
                Console.WriteLine("Failed");

            }
            driver.Close();


        }
        
    }
}
    
