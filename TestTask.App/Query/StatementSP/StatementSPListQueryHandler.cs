using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

using TestTask.App.Dtos;
using TestTask.Storage;

namespace TestTask.App.Query.StatementSP
{
    public class StatementSPListQueryHandler : IRequestHandler<StatementSPListQuery, ListDto<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementSPListQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ListDto<ApplicantDto>> Handle(StatementSPListQuery request, CancellationToken cancellationToken)
        {
            var statements = _storage.ApplicationSP.ToList();

            var result = statements.Select(statement => new ApplicantDto()
            {
                FIOApplicant = statement.FIOApplicant,
                DateBirth = statement.DateBirth,
                FIOChildOfApplicant = statement.FIOChildOfApplicant,
                DateBirthCildOfApplicant = statement.DateBirthCildOfApplicant,
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
