using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace Selenium_Test
{
    public class Tests
    {
        IWebDriver driver;
        string url = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName+"/Files/index.html";
       // string url = Directory.GetCurrentDirectory();
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}