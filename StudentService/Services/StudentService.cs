using AutoMapper;
using StudentService.DTOs;
using StudentService.Models;
using StudentService.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentService.Services
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _repository;
		private readonly IMapper _mapper;

		public StudentService(IStudentRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<StudentDTO>> GetAllAsync()
		{
			var students = await _repository.GetAllAsync();
			return _mapper.Map<StudentDTO>(students);
		}

		public async Task<StudentDTO> GetByIdAsync(Guid id)
		{
			var student = await _repository.GetByIdAsync(id);
			return _mapper.Map<StudentDTO>(student);
		}

		public async Task AddAsync(StudentDTO studentDto)
		{
			var student = _mapper.Map<Student>(studentDto);
			await _repository.AddAsync(student);
		}

		public async Task UpdateAsync(StudentDTO studentDto)
		{
			var student = _mapper.Map<Student>(studentDto);
			await _repository.UpdateAsync(student);
		}
		public async Task DeleteAsync(Guid id) => await _repository.DeleteAsync(id);
	}
}