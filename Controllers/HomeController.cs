using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Airplane.Models;

namespace Airplane.Controllers
{
    public class HomeController : Controller
    {
        private readonly connect _connect;

        public HomeController(connect connect)
        {
            _connect = connect ; 
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
