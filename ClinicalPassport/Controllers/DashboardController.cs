using ClinicalPassport.Models;
using ClinicalPassport.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Controllers
{
    
    [ApiController]
    [Route("dashboard")]
    public class DashboardController : ControllerBase
    {
        private ClinicalPassportContext _context { get; set; }

        public DashboardController(ClinicalPassportContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return new EmptyResult();
        }

        [HttpGet("index/{id}")]
        public DashboardViewModel Index(int id)
        {
            var dashboardViewModel = new DashboardViewModel
            {
                User = _context.Users.Find(id),
                TaskCompletions = _context.TaskCompletions.Include(tc => tc.Task).Where(tc => tc.StudentUserId == id).ToList()
            };

            return dashboardViewModel;
        }
        
        [HttpGet("progress/{userId}/{categoryId}")]
        public ProgressViewModel Progress(int userId, int categoryId)
        {
            var taskCompletions = _context.TaskCompletions.Include(tc => tc.Task).Where(tc => tc.StudentUserId == userId && tc.Task.CategoryID == categoryId).ToList();
            var tasks = _context.Tasks.Where(t => t.CategoryID == categoryId).ToList();
            var progressViewModel = new ProgressViewModel(taskCompletions, categoryId, tasks);

            return progressViewModel;
        }
        
        [HttpGet("/users/{id}")]
        public List<User> Users(int id)
        {
            var users = _context.Users.Where(u=> u.UserId == id).ToList();
            return users;
        }
    }
}
