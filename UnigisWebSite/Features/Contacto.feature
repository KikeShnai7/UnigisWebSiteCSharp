Feature: Contacto a Unigis 
	Cliente contacta a Unigis por medio del sitio web

Background:
	Given He navegado al sitio web de Unigis

@smoke
Scenario: TC1 Llenado incompleto del formulario de contacto
	When Doy clic en el boton Contacto
	And Lleno el formulario de contacto excepto un campo y doy clic en Enviar
  	Then Se muestra el mensaje "Rellena todos los campos obligatorios."


@regression
Scenario: TC2 Llenado incompleto del formulario de contacto
	When Doy clic en el boton Contacto
	And Lleno el formulario de contacto excepto un campo y doy clic en Enviar
  	Then Se muestra el mensaje "Rellena todos los campos obligatorios."