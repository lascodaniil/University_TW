using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingLog
{
    [TestClass]
    public class InstagramTest
    {
        private readonly IWebDriver _driver;
        public InstagramTest()
        {
            _driver = new ChromeDriver();
        }


        [TestMethod]
        public void InstagramMethod()
        {
            _driver.Navigate().GoToUrl("https://github.com/");
            _driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            _driver.FindElement(By.LinkText("Sign in")).Click();
            _driver.FindElement(By.Id("login_field")).SendKeys("lascodaniil@gmail.com");
            _driver.FindElement(By.Id("login_field")).Click();
            _driver.FindElement(By.Id("password")).SendKeys("ImonaGrup25I!");
            _driver.FindElement(By.Name("commit")).Click();
            _driver.FindElement(By.CssSelector(".col-md-3")).Click();

            Assert.AreEqual(_driver.Title, "GitHub");
        }



        [TestMethod]
        public void InstagramMethod1()
        {
            _driver.Navigate().GoToUrl("https://github.com/");
            _driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            _driver.FindElement(By.LinkText("Sign in")).Click();
            _driver.FindElement(By.Id("login_field")).SendKeys("lascodaniil@gmail.com");
            _driver.FindElement(By.Id("login_field")).Click();
            _driver.FindElement(By.Id("password")).SendKeys("dsaadasdsa!");
            _driver.FindElement(By.Name("commit")).Click();
            _driver.FindElement(By.CssSelector(".col-md-3")).Click();
            Assert.AreEqual(_driver.Title, "GitHub");
        }
    }
}
