using System.Threading;
using System.Threading.Tasks;
using MediatR;

using TestTask.Storage;
using TestTask.App.Dtos;
using TestTask.Domain;

namespace TestTask.App.Command.StatementHCS
{
    public class AddStatementHCSCommandHandler : IRequestHandler<AddStatementHCSCommand, Result>
    {
        private readonly IStorage _storage;
        public AddStatementHCSCommandHandler(IStorage storage) => _storage = storage;     

        public async Task<Result> Handle(AddStatementHCSCommand request, CancellationToken cancellationToken)
        {
            var statement = new ApplicationHCS()
            {
                Id = request.Id,
                FIOApplicant = request.FIOApplicant,
                PassportInfo = request.PassportInfo,
                DateBirth = request.DateBirth,
                FIOChildOfApplicant = request.FIOChildOfApplicant,
                BirthCertificate = request.BirthCertificate,
                DateBirthCildOfApplicant = request.DateBirthCildOfApplicant,
                AvailabilityOfBenefits = request.AvailabilityOfBenefits
            };

            _storage.ApplicationHCS.Add(statement);
            _storage.SaveChange();

            return new Result() { Status = HttpStatus.Ok };
        }
    }
}
