using System.Collections.Generic;

namespace ClinicalPassport.Models
{
	public class Task
	{
		public int TaskId { get; set; }
		public string Description { get; set; }
		public int CategoryID { get; set; }
		public Category Category { get; set; }
		public bool Required { get; set; }
		public virtual ICollection<TaskCompletion> TaskCompletions { get; set; }
    }
}
