using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementSPListQuery : IRequest<ListDto<ApplicantDto>>{}
}
