﻿using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Data.Results;

namespace SchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
