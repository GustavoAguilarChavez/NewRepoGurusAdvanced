using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecGurusAdvancedUAMCORE.Controllers
{
    public class DataController : Controller
    {
        //private IProductService _productService;
        //public DataController(IProductService productService, )
        //{
        //    _productService = productService;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
