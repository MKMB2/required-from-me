using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using واجب_رقم1.Models;

namespace واجب_رقم1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult text()
        {
            return View();
        }

        [HttpPost]
        public IActionResult text(test1 t)
        {
            string x = "";
            for (int i = t.Text.Length-1; i >= 0; i--)
            {
                x += t.Text[i];
            }
            ViewBag.name = x;

            return View();
        }

        public IActionResult calc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult calc(numbers n)
        {
            int result = 0;
            switch(n.operation)
            {
                case '+': result = n.numberOne + n.numberTow;break;
                case '/': result = n.numberOne / n.numberTow; break;

                case '-': result = n.numberOne - n.numberTow; break;
                case '*': result = n.numberOne * n.numberTow; break;

            }


            ViewBag.Result = result;

            return View();
        }
    }
    }
