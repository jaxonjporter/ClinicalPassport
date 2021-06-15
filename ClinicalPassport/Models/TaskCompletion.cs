using System;

namespace ClinicalPassport.Models
{
	public class TaskCompletion
	{
		public int TaskCompletionID { get; set; }
		public int StudentID { get; set; }
		public User Student { get; set; }
		public int FacultyID { get; set; }
		public User Faculty { get; set; }
		public int PreceptorID { get; set; }
		public User Preceptor { get; set; }
		public string PreceptorInitial { get; set; }
		public DateTime InitialDate { get; set; }
		public int TaskRating { get; set; }
    }
}
