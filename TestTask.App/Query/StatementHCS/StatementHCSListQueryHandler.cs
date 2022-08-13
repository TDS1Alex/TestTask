using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TestTask.App.Dtos;
using TestTask.Storage;

namespace TestTask.App.Query.StatementHCS
{
    public class StatementHCSListQueryHandler: IRequestHandler<StatementHCSListQuery, ListDto<ApplicantDto>>
    {
        private readonly IStorage _storage;
        public StatementHCSListQueryHandler(IStorage storage) => _storage = storage;

        public async Task<ListDto<ApplicantDto>> Handle(StatementHCSListQuery request, CancellationToken cancellationToken)
        {
            var statements = _storage.ApplicationHCS.Where(n => n.AvailabilityOfBenefits != null);

            var result = statements.Select(statement => new ApplicantDto()
            {
                Id = statement.Id,
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
