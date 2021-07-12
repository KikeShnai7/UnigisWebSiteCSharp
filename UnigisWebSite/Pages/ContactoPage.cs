using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnigisWebSite.Utils;

namespace UnigisWebSite.Pages
{
    class ContactoPage : WebActions
    {
        private IWebDriver driver;

        //WebElements
        private IWebElement txtNombre => driver.FindElement(By.Name("firstname"));
        private IWebElement txtApellido => driver.FindElement(By.Name("lastname"));
        private IWebElement txtCorreo => driver.FindElement(By.Name("email"));
        private IWebElement txtNumTel => driver.FindElement(By.Name("mobilephone"));
        private IWebElement txtNombreEmpresa => driver.FindElement(By.Name("company"));
        private IWebElement txtCargo => driver.FindElement(By.Name("jobtitle"));
        private IWebElement cmbPais => driver.FindElement(By.Name("pais"));
        private IWebElement cmbCantVehiculos => driver.FindElement(By.Name("cantidad_de_vehiculos"));
        private IWebElement txtMensaje => driver.FindElement(By.Name("message"));
        private IWebElement btnEnviar => driver.FindElement(By.XPath("//input[@value='Enviar']"));
        private IWebElement msjRellenaTdsCampsObligs => driver.FindElement(By.XPath("//label[text()='Rellena todos los campos obligatorios.']"));


        //Methods
        public ContactoPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void LlenarFormulario(string nombre, string apellido, string correo, string numTel, string empresa, string cargo, string pais,
            string cantidad, string mensaje)
        {
            driver.SwitchTo().Frame("hs-form-iframe-0");

            txtNombre.SendKeys(nombre);
            txtApellido.SendKeys(apellido);
            txtCorreo.SendKeys(correo);
            txtNumTel.SendKeys(numTel);
            txtNombreEmpresa.SendKeys(empresa);
            txtCargo.SendKeys(cargo);
            SelectByText(cmbPais, pais);
            SelectByText(cmbCantVehiculos, cantidad);
            txtMensaje.SendKeys(mensaje);

            Thread.Sleep(2000);

            btnEnviar.Click();

            driver.SwitchTo().DefaultContent();
        }

        public void ValidarMensaje(string msjEsperado)
        {
            driver.SwitchTo().Frame("hs-form-iframe-0");

            string msjActual = msjRellenaTdsCampsObligs.Text;

            Assert.AreEqual(msjActual, msjEsperado);

            driver.SwitchTo().DefaultContent();
        }

    }
}
