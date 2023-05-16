using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace ReverseNameApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult About(string name)
        {
            var reversedName = ReverseString(name);
            return View("About", reversedName);
        }

        private string ReverseString(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
