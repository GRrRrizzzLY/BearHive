using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirstTask
{
    [TestClass]
    public class FirstTask
    {
        [TestMethod]
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.kaspersky.com/";

            Thread.Sleep(2000);

            IWebElement MyKSign = driver.FindElement(By.LinkText("My Kaspersky"));
            MyKSign.Click();

            Thread.Sleep(2000);

            IWebElement SignInBtn = driver.FindElement(By.XPath("//div[3]/div[2]/button"));
            SignInBtn.Click();

            Thread.Sleep(2000);

            IWebElement EMailForm = driver.FindElement(By.Name("EMail"));
            EMailForm.SendKeys("test");

            Thread.Sleep(2000);

            IWebElement PassForm = driver.FindElement(By.XPath("//div[2]/div/div/div/form/div/div/input[2]"));
            PassForm.Click();
            PassForm.SendKeys("test");

            Thread.Sleep(2000);

            IWebElement GoBtn = driver.FindElement(By.XPath("//div[2]/div/div/div/form/div/div/button"));
            GoBtn.Click();

            Thread.Sleep(2000);

            if (driver.FindElement(By.XPath("//div[2]/div/div/div/form/div/div/div[3]/p")).Displayed == true)
            {
                Console.WriteLine("Элемент присутствует!");
            }
        }
    }
}
