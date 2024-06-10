using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniversityProject.Api.Base;
using UniversityProject.Core.Features.Emails.Commands.Models;
using UniversityProject.Data.AppMetaData;

namespace SchoolProject.Api.Controllers;

[ApiController]
[Authorize(Roles = "Admin,User")]
public class EmailsController : AppControllerBase
{
    [HttpPost(Router.EmailsRoute.SendEmail)]
    public async Task<IActionResult> SendEmail([FromQuery] SendEmailCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
}
