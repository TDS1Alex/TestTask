using Microsoft.EntityFrameworkCore;
using TestTask.Domain;

namespace TestTask.Storage
{
    public interface IStorage
    {
        DbSet<ApplicationHCS> Applicant { get; set; }

        void SaveChange();
    }
}
