using ClinicalPassport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private ClinicalPassportContext _context { get; set; }

        public HomeController(ClinicalPassportContext ctx)
        {
            _context = ctx;
        }

        [HttpPost]
        [Route("login")]
        public User Login([FromBody] int userId) {
            return _context.Users.Find(userId);
        }
    }
}
