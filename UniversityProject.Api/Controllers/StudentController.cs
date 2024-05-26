using MediatR;
using Microsoft.AspNetCore.Mvc;
using UniversityProject.Core.Feature.Student.Queries.Models;

namespace UniversityProject.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMediator _med;
    public StudentController(IMediator med) {
        _med = med;
    }
    [HttpGet("/Student/List")]
    public async Task<IActionResult> GetStudents()
    {
        var res = await _med.Send(new GetAllStudentQuery());
        return Ok(res);
    }
}
