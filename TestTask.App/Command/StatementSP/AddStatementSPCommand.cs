using MediatR;
using System;
using TestTask.App.Dtos;

namespace TestTask.App.Command.StatementSP
{
    public class AddStatementSPCommand: IRequest<Result>
    {
        public string FIOApplicant { get; set; }
        public string PassportInfo { get; set; }
        public DateTime DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public string BirthCertificate { get; set; }
        public DateTime DateBirthCildOfApplicant { get; set; }
        public int BankAccountNumber { get; set; }
    }
}
