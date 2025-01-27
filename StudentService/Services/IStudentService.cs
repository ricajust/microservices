using System;
using StudentService.DTOs;
using StudentService.Models;

namespace StudentService.Services
{
	public interface IStudentService
	{
		Task<IEnumerable<StudentDTO>> GetAllAsync();
		Task<StudentDTO> GetByIdAsync(Guid id);
		Task AddAsync(Student studentDto);
		Task UpdateAsync(StudentDTO studentDto);
		Task DeleteAsync(Guid id);
	}
}