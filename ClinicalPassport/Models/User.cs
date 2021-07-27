using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalPassport.Models
{
	public class User
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
		
		//[InverseProperty("Student")]
		//public virtual ICollection<TaskCompletion> StudentTaskCompletions { get; set; }
		
		//[InverseProperty("Faculty")]
  //      public virtual ICollection<TaskCompletion> FacultyTaskCompletions { get; set; }
		
		//[InverseProperty("Preceptor")]
  //      public virtual ICollection<TaskCompletion> PreceptorTaskCompletions { get; set; }
	}
}
