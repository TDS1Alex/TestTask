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
    public class StatementHCSQueryHandler: IRequestHandler<StatementHCSQuery, IEnumerable<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementHCSQueryHandler(IStorage storage) => _storage = storage;

        public async Task<IEnumerable<ApplicantDto>> Handle(StatementHCSQuery request, CancellationToken cancellationToken)
        {
            var statementsHCS = _storage.ApplicationHCS.ToList();

            var result = statementsHCS.Select(statement => new ApplicantDto()
            {
                FIOApplicant = statement.FIOApplicant,
                PassportInfo = statement.PassportInfo,
                DateBirth = statement.DateBirth,
                FIOChildOfApplicant = statement.FIOChildOfApplicant,
                BirthCertificate = statement.BirthCertificate,
                DateBirthCildOfApplicant = statement.DateBirthCildOfApplicant,
                AvailabilityOfBenefits = statement.AvailabilityOfBenefits
            });
            
            return result;
        }
    }
}
