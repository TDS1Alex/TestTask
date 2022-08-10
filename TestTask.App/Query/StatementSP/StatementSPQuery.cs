using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementSPQuery : IRequest<ApplicantDto>
    {
        public int Id { get; set; }
    }
}
