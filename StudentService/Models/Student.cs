using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentService.Models
{
	public class Student
	{
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		public DateTime EnrollmentDate { get; set; }

		public ICollection<Payment> Payments { get; set; }
	}
}
