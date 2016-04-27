﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminPortal.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Portal()
        {
            return View();
        }
    }
}
