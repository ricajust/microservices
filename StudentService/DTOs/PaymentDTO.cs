using System;

namespace StudentService.DTOs
{
	public class PaymentDTO
	{
		public Guid Id { get; set; }
		public decimal Amount { get; set; }
		public DateTime PaymentDate { get; set; }
	}
}