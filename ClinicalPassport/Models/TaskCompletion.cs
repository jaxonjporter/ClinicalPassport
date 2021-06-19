using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalPassport.Models
{
	public class TaskCompletion
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int TaskCompletionID { get; set; }
		
		[ForeignKey("TaskID")]
		public int TaskID { get; set; }

		public Task Task { get; set; }
		[ForeignKey("StudentUserID")]
		public int StudentUserID { get; set; }

		public User Student { get; set; }
		[ForeignKey("FacultyUserID")]

		public int FacultyUserID { get; set; }

		public User Faculty { get; set; }
		[ForeignKey("PreceptorUserID")]

		public int PreceptorUserID { get; set; }

		public User Preceptor { get; set; }
		public string PreceptorInitial { get; set; }
		public DateTime InitialDate { get; set; }
		public int TaskRating { get; set; }
    }
}
