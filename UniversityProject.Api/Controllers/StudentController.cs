using MediatR;
using Microsoft.AspNetCore.Mvc;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Core.Feature.Student.Queries.Models;
using static UniversityProject.Domain.AppMetaData.Router;

namespace UniversityProject.Api.Controllers;

[ApiController]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;
    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet(StudentRouting.List)]
    public async Task<IActionResult> GetStudentList()
    {
        var response = await _mediator.Send(new GetListStudentQuery());
        return Ok(response);
    }

    [HttpGet(StudentRouting.GetByID)]
    public async Task<IActionResult> GetStudentByID([FromRoute]int id)
    {
        var response = await _mediator.Send(new GetStudentByIdQuery(id));
        return Ok(response);
    }

    [HttpPost(StudentRouting.Create)]
    public async Task<IActionResult> AddStudentAsync([FromBody] AddStudentCommand model)
    {
        var response = await _mediator.Send(model);

        if (response.Succeeded)
        {
            return Created("Student added successfully", response.Data);
        }
        else
        {
            return BadRequest(response.Message);
        }
    }

}
