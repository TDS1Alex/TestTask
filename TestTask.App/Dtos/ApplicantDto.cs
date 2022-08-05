using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.App.Dtos
{
    public class ApplicantDto
    {
        public int Id { get; set; }
        public string FIOApplicant { get; set; }
        public string PassportInfo { get; set; }
        public int DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public string BirthCertificate { get; set; }
        public int DateBirthCildOfApplicant { get; set; }
        public string AvailabilityOfBenefits { get; set; }
        public int BankAccountNumber { get; set; }
    }
}
