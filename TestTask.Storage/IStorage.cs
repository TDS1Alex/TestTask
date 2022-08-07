using Microsoft.EntityFrameworkCore;
using TestTask.Domain;

namespace TestTask.Storage
{
    public interface IStorage
    {
        DbSet<Application> Application { get; set; }
        DbSet<ApplicationHCS> ApplicationHCS { get; set; }
        DbSet<ApplicationSP> ApplicationSP { get; set; }
        void SaveChange();
    }
}
