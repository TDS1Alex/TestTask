using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

using TestTask.App.Dtos;
using TestTask.Storage;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementSPQueryHandler : IRequestHandler<StatementSPQuery, IEnumerable<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementSPQueryHandler(IStorage storage) => _storage = storage;

        public async Task<IEnumerable<ApplicantDto>> Handle(StatementSPQuery request, CancellationToken cancellationToken)
        {
            var statements = _storage.ApplicationSP.ToList();

            var result = statements.Select(statement => new ApplicantDto()
            {
                FIOApplicant = statement.FIOApplicant,
                PassportInfo = statement.PassportInfo,
                DateBirth = statement.DateBirth,
                FIOChildOfApplicant = statement.FIOChildOfApplicant,
                BirthCertificate = statement.BirthCertificate,
                DateBirthCildOfApplicant = statement.DateBirthCildOfApplicant,
                BankAccountNumber = statement.BankAccountNumber
            });

            return result;
        }
    }
}
