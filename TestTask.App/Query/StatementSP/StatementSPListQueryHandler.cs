using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TestTask.App.Dtos;
using TestTask.Storage;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementSPListQueryHandler : IRequestHandler<StatementSPListQuery, ListDto<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementSPListQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ListDto<ApplicantDto>> Handle(StatementSPListQuery request, CancellationToken cancellationToken)
        {
            var statements = _storage.ApplicationSP.Where(n => n.BankAccountNumber != 0);

            var result = statements.Select(statement => new ApplicantDto()
            {
                Id = statement.Id,
                FIOApplicant = statement.FIOApplicant,
                PassportInfo = statement.PassportInfo,
                DateBirth = statement.DateBirth,
                FIOChildOfApplicant = statement.FIOChildOfApplicant,
                BirthCertificate = statement.BirthCertificate,
                DateBirthCildOfApplicant = statement.DateBirthCildOfApplicant,
                BankAccountNumber = statement.BankAccountNumber
            }).ToArray();

            var list = new ListDto<ApplicantDto>
            {
                Count = result.Length,
                Items = result
            };
            
            return list;
        }
    }
}
