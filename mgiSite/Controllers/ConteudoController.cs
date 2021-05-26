using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgiSite.Controllers
{
    public class ConteudoController : Controller
    {
        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Canal()
        {
            return View();
        }

        public IActionResult Materiais()
        {
            return View();
        }

    }
}
