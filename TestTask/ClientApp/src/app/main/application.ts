export class Application{
    constructor(
        public Id: number,
        public FIOApplicant: string,
        public PassportInfo: string,
        public DateBirth: Date,
        public FIOChildOfApplicant: string,
        public BirthCertificate: string,
        public DateBirthCildOfApplicant: Date,
        public AvailabilityOfBenefitsv: string,
        public BankAccountNumber: number){}
}