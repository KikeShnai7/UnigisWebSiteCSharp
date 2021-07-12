using System;
using System.Collections.Generic;
using System.Text;
using UnigisWebSite.Hooks;
using UnigisWebSite.Pages;
using OpenQA.Selenium.Support.PageObjects;

namespace UnigisWebSite.StepsDefinition
{
    class BaseSteps
    {
        protected HomePage home;
        protected ContactoPage contactPage;

        public BaseSteps()
        {
            home = new HomePage(Hooks1.driver);
            contactPage = new ContactoPage(Hooks1.driver);
        }

    }
}
