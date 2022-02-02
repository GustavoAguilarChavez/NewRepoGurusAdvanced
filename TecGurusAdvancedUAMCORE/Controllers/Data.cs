using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecGurusAdvancedUAMCORE.Controllers
{
    public class Data : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
