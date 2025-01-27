using Microsoft.AspNetCore.Mvc;
using StudentService.DTOs;
using StudentService.Services;
using System;
using System.Threading.Tasks;
	
namespace StudentService.Controllers
{
	[ApiController]
	[Route("api/students")]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService _service;

		public StudentController(IStudentService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id) => Ok(await _service.GetByIdAsync(id));

		[HttpPost]
		public async Task<IActionResult> Create(StudentDTO studentDto)
		{
			await _service.AddAsync(studentDto);
			return CreatedAtAction(nameof(GetById), new { id = studentDto.Id }, studentDto);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id, StudentDTO studentDto)
		{
			studentDto.Id = id;
			await _service.UpdateAsync(studentDto);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			await _service.DeleteAsync(id);
			return NoContent();
		}
	}
}
