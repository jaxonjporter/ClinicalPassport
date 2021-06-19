using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
		public virtual ICollection<TaskCompletion> TaskCompletions { get; set; }
	}
}
