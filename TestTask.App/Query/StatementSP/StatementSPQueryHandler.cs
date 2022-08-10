using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TestTask.App.Dtos;
using TestTask.Storage;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementSPQueryHandler : IRequestHandler<StatementSPQuery, ApplicantDto>
    {
        private readonly IStorage _storage;
        public StatementSPQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ApplicantDto> Handle(StatementSPQuery request, CancellationToken cancellationToken)
        {
            var statement = _storage.ApplicationSP.FirstOrDefault(n => n.Id == request.Id);

            var result = new ApplicantDto()
            {
                Id = statement.Id,
                FIOApplicant = statement.FIOApplicant,
                PassportInfo = statement.PassportInfo,
                DateBirth = statement.DateBirth,
                FIOChildOfApplicant = statement.FIOChildOfApplicant,
                BirthCertificate = statement.BirthCertificate,
                DateBirthCildOfApplicant = statement.DateBirthCildOfApplicant,
                BankAccountNumber = statement.BankAccountNumber
            };

            return result;
        }
    }
}
