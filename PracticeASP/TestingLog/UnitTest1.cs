using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestingLog
{
    [TestClass]
    public class UnitTest1 
    {
        private readonly IWebDriver _driver;
        public UnitTest1()
        {
            _driver = new ChromeDriver();
        }


        [TestMethod]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("http://localhost:57508");
            _driver.Manage().Window.Size= new System.Drawing.Size(1000, 500);
            _driver.Quit();
            _driver.FindElement(By.Name("Email")).SendKeys("lascodaniil4@gmail.com");
            _driver.FindElement(By.Name("Password")).SendKeys("password123");
            _driver.FindElement(By.Id("home-content-box-inner")).Click();
        }
    }
}
