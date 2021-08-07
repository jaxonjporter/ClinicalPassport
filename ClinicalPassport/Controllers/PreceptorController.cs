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
    [Route("preceptor")]
    public class PreceptorController : ControllerBase
    {
        private ClinicalPassportContext _context { get; set; }

        public PreceptorController(ClinicalPassportContext ctx)
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

        [HttpGet("{id}")]
        public PreceptorViewModel Index(int id)
        {
            var preceptorViewModel = new PreceptorViewModel
            {
                User = _context.Users.Find(id),
                TaskCompletions = _context.TaskCompletions.Include(tc => tc.Task.Category).Include(tc => tc.Student).Where(tc => tc.StudentCompleted).ToList()
            };

            return preceptorViewModel;
        }
        
        [HttpGet("progress/{userId}/{categoryId}")]
        public ProgressViewModel Progress(int userId, int categoryId)
        {
            var taskCompletions = _context.TaskCompletions.Include(tc => tc.Task).Where(tc => tc.StudentUserId == userId && tc.Task.CategoryID == categoryId && tc.PreceptorInitial == string.Empty).ToList();
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

        [HttpPost]
        [Route("deny")]
        public TaskCompletion Deny([FromBody] int taskCompletionId)
        {
            var tc = _context.TaskCompletions.Find(taskCompletionId);
            tc.StudentCompleted = false;
            _context.Update(tc);
            _context.SaveChanges();
            return tc;
        }

        [HttpPost]
        [Route("approve")]
        public TaskCompletion Approve([FromBody] int taskCompletionId)
        {
            var tc = _context.TaskCompletions.Find(taskCompletionId);
            tc.PreceptorInitial = "JP";
            tc.InitialDate = DateTime.Today;
            tc.StudentCompleted = true;
            _context.Update(tc);
            _context.SaveChanges();
            return tc;
        }

    }
}
