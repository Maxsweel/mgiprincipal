using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgiSite.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
    }
}
