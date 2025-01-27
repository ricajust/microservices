using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentService.DTOs;

namespace StudentService.Services
{
	public interface IStudentService
	{
		Task<IEnumerable<StudentDTO>> GetAllAsync();
		Task<StudentDTO> GetByIdAsync(Guid id);
		Task AddAsync(StudentDTO studentDto);
		Task UpdateAsync(StudentDTO studentDto);
		Task DeleteAsync(Guid id);
	}
}