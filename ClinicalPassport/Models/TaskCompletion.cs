using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalPassport.Models
{
	public class TaskCompletion
	{
		public int TaskCompletionId { get; set; }

		[ForeignKey("TaskId")]
		public int TaskId { get; set; }

		[ForeignKey("UserId")]
		public int StudentUserId { get; set; }

		[ForeignKey("UserId")]
		public int FacultyUserId { get; set; }

		[ForeignKey("UserId")]
		public int PreceptorUserId { get; set; }

		public string PreceptorInitial { get; set; }

		public DateTime InitialDate { get; set; }

		public int TaskRating { get; set; }
    }
}
