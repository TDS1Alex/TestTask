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
    public class StatementHCSListQueryHandler : IRequestHandler<StatementHCSListQuery, ListDto<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementHCSListQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ListDto<ApplicantDto>> Handle(StatementHCSListQuery request, CancellationToken cancellationToken)
        {
            var statements = _storage.ApplicationHCS.ToList();

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
