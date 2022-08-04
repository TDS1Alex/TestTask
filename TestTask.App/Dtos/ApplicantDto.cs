using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.App.Dtos
{
    public class ApplicantDto
    {
        public string FIOApplicant { get; set; }
        public int DateBirth { get; set; }
        public string FIOChildOfApplicant { get; set; }
        public int DateBirthCildOfApplicant { get; set; }
    }
}
