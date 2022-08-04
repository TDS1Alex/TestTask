using System.Threading;
using System.Threading.Tasks;
using MediatR;

using TestTask.Storage;
using TestTask.App.Dtos;
using TestTask.Domain;

namespace TestTask.App.Command.StatementSP
{
    public class AddStatementSPCommandHandler : IRequestHandler<AddStatementSPCommand, Result>
    {
        private readonly IStorage _storage;

        public AddStatementSPCommandHandler(IStorage storage)
        {
            _storage = storage;
        }

        public async Task<Result> Handle(AddStatementSPCommand request, CancellationToken cancellationToken)
        {
            var statement = new ApplicationSP()
            {
                Id = request.Id,
                FIOApplicant = request.FIOApplicant,
                PassportInfo = request.PassportInfo,
                DateBirth = request.DateBirth,
                FIOChildOfApplicant = request.FIOChildOfApplicant,
                BirthCertificate = request.BirthCertificate,
                DateBirthCildOfApplicant = request.DateBirthCildOfApplicant,
                BankAccountNumber = request.BankAccountNumber
            };

            _storage.ApplicationSP.Add(statement);
            _storage.SaveChange();

            return new Result() { Status = HttpStatus.Ok };
        }
    }
}
