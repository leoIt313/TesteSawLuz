using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteSawLuz.Application.Interfaces;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Models;

namespace TesteSawLuz.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}
