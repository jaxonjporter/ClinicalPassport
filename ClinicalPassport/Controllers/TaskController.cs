using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ClinicalPassport.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicalPassport.Controllers
{
    public class TaskController : Controller
    {
        private ClinicalPassportContext context { get; set; }

        public TaskController(ClinicalPassportContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tasks = context.TaskCompletions
                .Include(t => t.Task)
                .Include(t => t.Task.Category)
                .OrderBy(t => t.TaskId)
                .ToList();
            return View(tasks);
        }
    }
}
