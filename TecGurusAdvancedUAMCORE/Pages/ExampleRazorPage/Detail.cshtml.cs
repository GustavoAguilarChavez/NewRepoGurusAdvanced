using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TecGurusAdvancedUAMCORE.Pages.ExampleRazorPage
{
    public class DetailModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet(int Id)
        {
            Message = "Tu numero de la suerte es: "
                + Id.ToString();
        }
    }
}
