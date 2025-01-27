using System;
using StudentService.Models;

namespace StudentService.Repositories
{
	public interface IStudentRepository
	{
		Task<IEnumerable<Student>> GetAllAsync();
		Task<Student> GetByIdAsync(Guid id);
		Task AddAsync(Student student);
		Task UpdateAsync(Student student);
		Task DeleteAsync(Guid id);
	}
}