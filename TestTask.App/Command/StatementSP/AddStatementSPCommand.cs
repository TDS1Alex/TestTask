using MediatR;
using System;
using TestTask.App.Dtos;

namespace TestTask.App.Command.StatementSP
{
    public class AddStatementSPCommand: IRequest<Result>
    {
        public string FIOApplicant { get; set; }
        public string PassportInfo { get; set; }
        public string DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public string BirthCertificate { get; set; }
        public string DateBirthCildOfApplicant { get; set; }
        public int BankAccountNumber { get; set; }
    }
}
