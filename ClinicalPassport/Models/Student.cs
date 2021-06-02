using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Models
{
	public class Student
	{
		public int StudentID { get; set; }
		public string Name { get; set; }
		public DateTime DOB { get; set; }
		public string Address { get; set; }
	}
}
