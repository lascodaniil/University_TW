using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
        public void TryScrappingData()
        {
            _driver.Navigate().GoToUrl("https://www.smart.md/");
            _driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            _driver.FindElement(By.XPath("/html/body/div[5]/div/div[4]/div[1]/a[1]/div[1]/img")).Click();
            string path = @"C:\Users\Daniil\Desktop\Delegate\result.txt";
            string tmp = @"C:\Users\Daniil\Desktop\Delegate";
            try
            {
                while (!HasClass(_driver.FindElement(By.XPath("/html/body/section/div[2]/div[4]/div[2]/div[3]/div[1]/li[10]")), "disabled"))
                {

                    var item = _driver.FindElements(By.ClassName("pre_bloc_prod_cont"));
                    foreach (var i in item)
                    {

                        using (StreamWriter sw = File.AppendText(path))
                        {
                            try
                            {
                                sw.Write(i.Text);
                                sw.WriteLine("==================");
                                sw.WriteLine();
                                string element =  _driver.FindElement(By.XPath("/html/body/section/div[2]/div[4]/div[2]/div[2]/div[61]/div/a[1]/img")).Text;
                                using (WebClient client = new WebClient()) {
                                    client.DownloadFile(new Uri(element), tmp);
                                    Console.WriteLine("HERE IMAGE");
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    _driver.FindElement(By.XPath(" / html/body")).Click();
                    _driver.FindElement(By.XPath("/html/body/section/div[2]/div[4]/div[2]/div[3]/div[1]/li[10]")).Click();

                }
            }
            catch
            {
                
            }
            

        }

        public static bool HasClass(IWebElement el, string className)
        {
            return el.GetAttribute("class").Split(' ').Contains(className);
        }

    }
}

