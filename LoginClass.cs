using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_Training
{
    [TestClass]
    public class LoginClass : Base_Class
    {
        [TestMethod]
        public void ValidCredentials1()
        {
            driver.FindElement(By.CssSelector("input[id='user-name']")).SendKeys("standard_user");
            driver.FindElement(By.CssSelector("input[id='password']")).SendKeys("secret_sauce");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }

        // Case2: Write positive case with 
        [TestMethod]
        public void ValidCredentials2()
        {
            driver.FindElement(By.CssSelector("input[id='user-name']")).SendKeys("standard_user");
            driver.FindElement(By.CssSelector("input[id='password']")).SendKeys("secret_sauce");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }

        // Case3: Write negative case using invalid credentials
        [TestMethod]
        public void InValidCredentials1()
        {
            driver.FindElement(By.CssSelector("input[id='user-name']")).SendKeys("nadia.khan");
            driver.FindElement(By.CssSelector("input[id='password']")).SendKeys("pearls123");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
            Assert.AreNotEqual("https://www.saucedemo.com/", driver.Url);
        }



        // Write negative case using empty credentials
        [TestMethod]
        public void EmptyCredentials2()
        {
            driver.FindElement(By.CssSelector("input[id='user-name']")).SendKeys("");
            driver.FindElement(By.CssSelector("input[id='password']")).SendKeys("");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }


        // Write negative case using Valid Username and Wrong password credentials
        [TestMethod]
        public void ValidUsrname_InvalidPassword3()
        {
            driver.FindElement(By.CssSelector("input[id='user-name']")).SendKeys("standard_user");
            driver.FindElement(By.CssSelector("input[id='password']")).SendKeys("pearls123");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
            //  driver.FindElement(By.ClassName("error-button"));
            Assert.IsTrue(driver.Url.Equals("https://www.saucedemo.com/"));
        }


    }
}
