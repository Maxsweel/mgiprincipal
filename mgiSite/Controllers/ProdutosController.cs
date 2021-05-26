using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgiSite.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Ecommerce()
        {
            return View();
        }

        public IActionResult Erp()
        {
            return View();
        }

        public IActionResult Sistemas()
        {
            return View();
        }
    }
}
