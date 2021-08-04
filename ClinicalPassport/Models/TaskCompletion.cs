using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalPassport.Models
{
	public class TaskCompletion
	{
		public int TaskCompletionId { get; set; }

		public int TaskId { get; set; }
		public Task Task { get; set; }

		public int StudentUserId { get; set; }

		//public User Student { get; set; }

		public int FacultyUserId { get; set; }
		//public User Faculty { get; set; }

		public int PreceptorUserId { get; set; }
		//public User Preceptor { get; set; }

		public string PreceptorInitial { get; set; }

		public DateTime InitialDate { get; set; }

		public bool StudentCompleted { get; set; }

		public int TaskRating { get; set; }
    }
}