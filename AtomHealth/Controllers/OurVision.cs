﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AtomHealth.Controllers
{
    public class OurVision : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
