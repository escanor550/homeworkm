using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult About(int number1, int number2)
        {
            ViewData["Number1"] = number1;
            ViewData["Number2"] = number2;
            ViewData["Addition"] = number1 + number2;
            ViewData["Multiplication"] = number1 * number2;
            ViewData["Subtraction"] = number1 - number2;
            ViewData["Division"] = number1 / number2;

            return View();
        }
    }
}
