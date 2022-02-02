using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecGurusAdvancedUAMCORE.Models;

namespace TecGurusAdvancedUAMCORE.Pages.Course
{
    //Bindea todas las propiedades de la clase
    [BindProperties]
    public class ExampleRazorPageModel : PageModel
    {

        public ExampleRazorPageModel()
        {

        }

        // Los binding son intercambio de informacion entre mi modelo y mi vista
        //si no se pone el bind property no se recuperan los datos de la vista
        //[BindProperty]
        public PersonaModel Persona { get; set; }
        public List<string> Dias { get; set; }
        public string Mensaje { get; set; }
        //[BindProperty]
        public int Numero { get; set; }
        public string Letras { get; set; }

        //desde la vista si no le especifico el nombre tal cual del parametro, llega null
        public void OnPost(string parametroString)
        {
            OnGet();
        }


        //Eviar un valor a otra Razor Page con query string

        public IActionResult OnPostRedirectParameter()
        {
            var numero = Numero;

            return RedirectToPage("/ExampleRazorPage/Detail",
                new { Id = numero });

        }

        public IActionResult OnPostRedirectTwoParameters()
        {
            var numero = Numero;
            var letras = Letras;
            return RedirectToPage("/ExampleRazorPage/EjeQueryString", new { Id = numero, Letras = letras });
        }

        //Para pasar informacion de un Page a otro, podria ser por query string
        //pero puedo utilizar un TempData el cual me permite almacenar de manera temporal
        //informacion primitiva o string  int etc, no clases
        //definidas por mi como es persona, el valor que establesca aqui a nombre se va a replicar
        //en ExampleTempData, por regla debe llamarse igual
        //TempData

        [TempData]
        public string Nombre { get; set; }

        [TempData]
        public string Apellido { get; set; }

        public IActionResult OnPostRedirectTareaTempDataParameter()
        {
            Nombre = "Gustavo Andrés";
            Apellido = "Aguilar";
            return RedirectToPage("/ExampleRazorPage/TareaTempData");
        }



        //Recuperar 3 parametros de un formulario de tipo primitivo,  redirigirlos a un nuevo 
        //RP TareaTempData, y mostrarlos en la vista 



        //Como se hacia anteriormente en MVC
        //Si quisiera obtener el model persona  de la vista, normalmente en mvc
        // se recibiria el modelo como parametro aqui en razor page es diferente
        //public void OnPostPersona(Persona persona)
        //{

        //}
        public void OnPostPersona()
        {
            var persona = Persona;
        }

        //public void OnGet(PersonaModel persona)
        //{

        //}

        //ejercicio crear un solo Form para Persona y Pais (clase con Id y nombrePais)
        //Recibir los datos em un metodo Post PersonaPais y monstrarlos en el metodo Get
        //en etiquetas de Html <h4>

        //Metodo de inicio por convencion 
        public void OnGet()
        {
            Mensaje = "Bienvenido";
            //Nota utilizando propiedades del ViewModel
            //mostrar un saludo y la hora actual en la vista
            //hr
            //Ejericio mostrar datos de una persona en la vista
            //hr
            //Mostrar La lista de dias de la semana en la vista 
            //hr
            //Ejericio mostrar 3 personas  en la vista odenadas por su nombre de madera descendente

        }

    }
}
