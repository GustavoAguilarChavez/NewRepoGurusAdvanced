using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TecGurusAdvancedUAMCORE.Pages.Course
{
 
    public class TareaTempDataModel : PageModel
    {
        [TempData]
        public string Nombre { get; set; }

        [TempData]
        public int Apellido { get; set; }

        [TempData]
        public string Vcampo1 { get; set; }

        public void OnGet()
        {
            Vcampo1 = "Los parametros son 1: " + Nombre + " 2: " + Apellido;
        }
    }
}
