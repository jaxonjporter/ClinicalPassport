using ClinicalPassport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Controllers
{
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private ClinicalPassportContext _context { get; set; }

        public DashboardController(ClinicalPassportContext ctx)
        {
            _context = ctx;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return Json("Hi");
        //}

        [HttpGet]
        public List<User> Index(int id)
        {
            var users = _context.Users.ToList();
            return users;
        }
        
        [HttpGet]
        public List<User> Users(int id)
        {
            var users = _context.Users.Where(u=> u.UserId == id).ToList();
            return users;
        }
    }
}
