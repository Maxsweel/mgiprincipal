using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgiSite.Controllers
{
    public class InstitucionalController : Controller
    {
        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Valores()
        {
            return View();
        }
    }
}
