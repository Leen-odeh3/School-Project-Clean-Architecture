using MediatR;
using Microsoft.AspNetCore.Mvc;
using UniversityProject.Api.Base;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Core.Feature.Student.Queries.Models;
using static UniversityProject.Domain.AppMetaData.Router;

namespace UniversityProject.Api.Controllers;

[ApiController]
public class StudentController : AppControllerBase
{
    [HttpGet(StudentRouting.List)]
    public async Task<IActionResult> GetStudentList()
    {
        var response = await Mediator.Send(new GetListStudentQuery());
        return NewResult(response);
    }

    [HttpGet(StudentRouting.GetByID)]
    public async Task<IActionResult> GetStudentByID([FromRoute]int id)
    {
        var response = await Mediator.Send(new GetStudentByIdQuery(id));
        return NewResult(response);
    }

    [HttpPost(StudentRouting.Create)]
    public async Task<IActionResult> AddStudentAsync([FromBody] AddStudentCommand model)
    {
        var response = await Mediator.Send(model);
        return NewResult(response);
    }

    [HttpPut(StudentRouting.Edit)]
    public async Task<IActionResult> UpdateStudentAsync([FromBody] EditStudentCommand model)
    {
        var response = await Mediator.Send(model);
        return NewResult(response);
    }

}
