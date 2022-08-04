using MediatR;
using TestTask.App.Dtos;

namespace TestTask.App.Command
{
    public class AddStatementHCSCommand: IRequest<Result>
    {
        public string FIOApplicant { get; set; }
        public string PassportInfo { get; set; }
        public int DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public string BirthCertificate { get; set; }
        public int DateBirthCildOfApplicant { get; set; }
        public string AvailabilityOfBenefits { get; set; }
    }
}
