﻿using System;
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
    public class StatementHCSListQueryHandler: IRequestHandler<StatementSPListQuery, ListDto<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementHCSListQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ListDto<ApplicantDto>> Handle(StatementSPListQuery request, CancellationToken cancellationToken)
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
