﻿using ClinicalPassport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Controllers
{
    public class HomeController : Controller
    {
        private ClinicalPassportContext _context { get; set; }

        public HomeController(ClinicalPassportContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        [Route("/test/{userId}")]
        public IActionResult Index(string userId)
        {

            var data = _context.Users;
            return Json(data);
        }
    }
}
