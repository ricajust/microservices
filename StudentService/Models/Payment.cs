using System;
using System.ComponentModel.DataAnnotations;

namespace StudentService.Models
{
	public class Payment
	{
		[Key]
		public Guid Id {get; set;} = Guid.NewGuid();

		[Required]
		public Guid StudentId { get; set; }

		[Required]
		public decimal Amount { get; set; }

		[Required]
		public DateTime PaymentDate { get; set; }

		public Student Student { get; set; }
	}
}