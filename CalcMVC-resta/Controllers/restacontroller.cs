using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace Calculadora.Controllers
{
    public class restaController : Controller
    {
        public IActionResult resta()
        {
            ViewData["Resta"]="24-4=20";
            return View();
        }


       
    }
}
