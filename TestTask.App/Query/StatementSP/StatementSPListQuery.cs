using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementSPListQuery : IRequest<ListDto<ApplicantDto>>
    {
        public int Id { get; set; }

    }
}
