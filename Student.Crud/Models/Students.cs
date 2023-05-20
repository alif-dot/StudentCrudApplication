using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student.Crud.Models
{
	public class Students
	{
		[Key]
		public int StudentId { get; set; }

		[Required]
		public string StudentName { get; set; }

		[Required]
		public string FatherName { get; set; }

		[Required]
		public string MotherName { get; set; }

		[Required]
		public DateTime BirthDay { get; set; }

		[Required]
		public string Gender { get; set; }

		[Required]
		public string Phone { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public string Address { get; set; }

		[Required]
		public string Subject { get; set; }

		[Required]
		public string Batch { get; set; }
	}
}