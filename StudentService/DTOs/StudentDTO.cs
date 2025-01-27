using System;
using System.Collections.Generic;

namespace StudentService.DTOs
{
	public class StudentDTO
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime EnrollmentDate { get; set; }
		public ICollection<PaymentDTO> Payments { get; set; }
	}
}