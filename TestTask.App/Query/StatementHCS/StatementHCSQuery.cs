using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementHCSQuery : IRequest<ApplicantDto>
    {
        public int Id { get; set; }
    }
}
