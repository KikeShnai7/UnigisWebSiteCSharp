using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UnigisWebSite.Hooks
{
    [Binding]
    class Hooks1
    {
        public static IWebDriver driver;

        [Before]
        public void BrowserUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [After]
        public void BrowserClose()
        {
            driver.Close();
        }
    }
}
