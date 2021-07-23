using ClinicalPassport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Controllers
{
    public class DashboardController : Controller
    {
        private ClinicalPassportContext _context { get; set; }

        public DashboardController(ClinicalPassportContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Json("Hi");
        }


        [HttpPost]
        public IActionResult Index(int userId)
        {
            return Json(userId);
        }
    }
}
