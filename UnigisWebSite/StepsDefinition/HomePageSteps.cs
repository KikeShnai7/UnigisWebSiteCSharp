using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace UnigisWebSite.StepsDefinition
{
    [Binding]
    class HomePageSteps : BaseSteps
    {
        [When(@"Doy clic en el boton Contacto")]
        public void WhenDoyClicEnElBotonContacto()
        {
            home.ClickOnContacto();
        }

    }
}
