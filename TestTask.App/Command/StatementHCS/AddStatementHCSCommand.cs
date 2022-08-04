using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Command.StatementHCS
{
    public class AddStatementHCSCommand: IRequest<Result>
    {
        public int Id { get; set; }
        public string FIOApplicant { get; set; }
        public string PassportInfo { get; set; }
        public int DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public string BirthCertificate { get; set; }
        public int DateBirthCildOfApplicant { get; set; }
        public string AvailabilityOfBenefits { get; set; }
    }
}
