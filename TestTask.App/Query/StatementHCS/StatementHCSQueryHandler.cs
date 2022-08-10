using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TestTask.App.Dtos;
using TestTask.Storage;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementHCSQueryHandler: IRequestHandler<StatementHCSQuery, ApplicantDto>
    {
        private readonly IStorage _storage;
        public StatementHCSQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ApplicantDto> Handle(StatementHCSQuery request, CancellationToken cancellationToken)
        {
            var statement = _storage.ApplicationHCS.FirstOrDefault(n => n.Id == request.Id);

            var result = new ApplicantDto()
            {
                Id = statement.Id,
                FIOApplicant = statement.FIOApplicant,
                PassportInfo = statement.PassportInfo,
                DateBirth = statement.DateBirth,
                FIOChildOfApplicant = statement.FIOChildOfApplicant,
                BirthCertificate = statement.BirthCertificate,
                DateBirthCildOfApplicant = statement.DateBirthCildOfApplicant,
                AvailabilityOfBenefits = statement.AvailabilityOfBenefits
            };

            return result;
        }
    }
}
