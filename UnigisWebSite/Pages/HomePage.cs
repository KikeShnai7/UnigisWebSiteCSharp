using OpenQA.Selenium;
using System;

namespace UnigisWebSite.Pages
{
    class HomePage
    {
        private IWebDriver driver;

        //WebElements
        private IWebElement btnContacto => driver.FindElement(By.XPath("//a[text()='Contacto']"));


        //Methods
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnContacto()
        {
            btnContacto.Click();
        }
    }
}
