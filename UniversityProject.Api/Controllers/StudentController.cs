using MediatR;
using Microsoft.AspNetCore.Mvc;
using UniversityProject.Core.Feature.Student.Queries.Models;

namespace UniversityProject.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;
    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("/Students")]
    public async Task<IActionResult> GetStudentList()
    {
        var response = await _mediator.Send(new GetListStudentQuery());
        return Ok(response);
    }

    [HttpGet("/Students/{id}")]
    public async Task<IActionResult> GetStudentByID([FromRoute]int id)
    {
        var response = await _mediator.Send(new GetStudentByIdQuery(id));
        return Ok(response);
    }

}
