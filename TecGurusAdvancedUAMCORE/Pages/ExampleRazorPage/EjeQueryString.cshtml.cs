using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TecGurusAdvancedUAMCORE.Pages.ExampleRazorPage
{
    public class EjeQueryStringModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet(int Id, string Letras)
        {
            Message = "Tu parametro 1 es: " + Id + " Tu parametro 2 es: " + Letras;
        }
    }
}
