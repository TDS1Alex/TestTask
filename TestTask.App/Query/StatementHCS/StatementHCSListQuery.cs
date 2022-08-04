using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementHCSListQuery : IRequest<ListDto<ApplicantDto>>{}
}
