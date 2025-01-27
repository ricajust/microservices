using Microsoft.EntityFrameworkCore;
using StudentService.Data;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentService.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly AppDbContext _context;

		public StudentRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Student>> GetAllAsync() => await _context.Students.Include(s => s.Payments).ToListAsync();

		public async Task<Student> GetByIdAsync(Guid id) => await _context.Students.Include(s => s.Payments).FirstOrDefaultAsync(s => s.Id == id);

		public async Task AddAsync(Student student)
		{
			await _context.Students.AddAsync(student);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Student student)
		{
			_context.Students.Update(student);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Guid id)
		{
			var student = await GetByIdAsync(id);
			if (student != null)
			{
				_context.Students.Remove(student);
				await _context.SaveChangesAsync();
			}
		}
	}
}
