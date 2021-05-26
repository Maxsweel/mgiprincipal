using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgiSite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Erp()
        {
            return View();
        }

        public IActionResult Portal()
        {
            return View();
        }

    }
}
