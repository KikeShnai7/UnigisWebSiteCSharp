using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using UnigisWebSite.Hooks;

namespace UnigisWebSite.Utils
{
    class WebActions
    {
		public WebDriverWait waiter()
		{
			WebDriverWait waiter = new WebDriverWait(Hooks1.driver, TimeSpan.FromSeconds(15));
			return waiter;
		}//waiter

		public void SelectByText(IWebElement cmbElement, string visibleText)
		{
			SelectElement selector = new SelectElement(cmbElement);
			selector.SelectByText(visibleText);
		}//SelectByText

	}
}
