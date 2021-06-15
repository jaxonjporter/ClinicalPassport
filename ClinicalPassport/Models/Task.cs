namespace ClinicalPassport.Models
{
	public class Task
	{
		public int TaskID { get; set; }
		public string Description { get; set; }
		public string CategoryID { get; set; }
		public Category Category { get; set; }
		public bool Required { get; set; }
    }
}
