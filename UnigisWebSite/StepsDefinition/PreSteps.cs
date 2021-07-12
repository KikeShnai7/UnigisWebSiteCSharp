using TechTalk.SpecFlow;
using UnigisWebSite.Pages;
using UnigisWebSite.Hooks;

namespace UnigisWebSite.StepsDefinition
{
    [Binding]
    class PreSteps : BaseSteps
    {
        [Given(@"He navegado al sitio web de Unigis")]
        public void GivenHeNavegadoAlSitioWebDeUnigis()
        {
            home.GoToURL("https://www.unigis.com/");
        }
    }
}