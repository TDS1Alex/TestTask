using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementHCSQuery : IRequest<IEnumerable<ApplicantDto>>
    {
        public int Id { get; set; }
    }
}
