using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace WebScrapper
{
    [TestClass]
    public class EdgeDriverTest
    {
        private readonly IWebDriver _driver;
        public EdgeDriverTest()
        {
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void TryScrappingData()
        {
            _driver.Navigate().GoToUrl("https://www.zap.md/");
            _driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            _driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[0]/a")).Click();
        }




    }
}
