using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementHCSListQuery : IRequest<ListDto<ApplicantDto>>
    {
        public string FIOApplicant { get; set; }
        public int DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public int DateBirthCildOfApplicant { get; set; }
    }
}
