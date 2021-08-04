using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Models.ViewModels
{
    public class ProgressViewModel
    {
        public List<TaskCompletion> TaskCompletions { get; set; }
        public int CategoryId { get; set; }
        public decimal CompletedPercent { get; set; }
        public decimal UnderReviewPercent { get; set; }
        public decimal NotCompletePercent { get; set; }
        public List<Task> Tasks { get; set; }
        public ProgressViewModel(List<TaskCompletion> taskCompletions, int categoryId, List<Task> tasks)
        {
            TaskCompletions = taskCompletions;
            CategoryId = categoryId;
            Tasks = tasks;
            CompletedPercent = GetCompletedPercent();
            UnderReviewPercent = GetUnderReviewPercent();
            NotCompletePercent = GetNotCompletePercent();
        }


        private decimal GetCompletedPercent()
        {
            return TaskCompletions.Count(tc => tc.StudentCompleted && tc.PreceptorInitial != "" && tc.Task.CategoryID == CategoryId) / (decimal)TaskCompletions.Count(tc => tc.Task.CategoryID == CategoryId) * 100;
        }

        private decimal GetUnderReviewPercent()
        {
            return TaskCompletions.Count(tc => tc.StudentCompleted && tc.PreceptorInitial == "" && tc.Task.CategoryID == CategoryId) / (decimal)TaskCompletions.Count(tc => tc.Task.CategoryID == CategoryId) * 100;
        }


        private decimal GetNotCompletePercent()
        {
            return TaskCompletions.Count(tc => !tc.StudentCompleted && tc.Task.CategoryID == CategoryId) / (decimal)TaskCompletions.Count(tc => tc.Task.CategoryID == CategoryId) * 100;
        }
    }
}
