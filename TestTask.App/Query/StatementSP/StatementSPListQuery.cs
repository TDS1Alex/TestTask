using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementSP
{
    public class StatementSPListQuery : IRequest<ListDto<ApplicantDto>>
    {
        public string FIOApplicant { get; set; }
        public int DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public int DateBirthCildOfApplicant { get; set; }
    }
}
