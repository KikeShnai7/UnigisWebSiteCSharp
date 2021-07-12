using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace UnigisWebSite.StepsDefinition
{
    [Binding]
    class ContactoPagSteps : BaseSteps
    {
        [When(@"Lleno el formulario de contacto excepto un campo y doy clic en Enviar")]
        public void WhenLlenoElFormularioDeContactoExceptoUnCampoYDoyClicEnEnviar()
        {
            contactPage.LlenarFormulario("Enrique", "Garcia", "kike07@gmail.com", "5521757435", "Mi empresa", "Director", "Alemania", "0-30","");
        }

        [Then(@"Se muestra el mensaje ""(.*)""")]
        public void ThenSeMuestraElMensaje(string msjEsperado)
        {
            contactPage.ValidarMensaje(msjEsperado);
        }


    }
}
