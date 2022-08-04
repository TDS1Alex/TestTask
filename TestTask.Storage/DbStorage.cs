using Microsoft.EntityFrameworkCore;
using TestTask.Domain;

namespace TestTask.Storage
{
    public class DbStorage : DbContext, IStorage
    {
        public DbSet<ApplicationHCS> ApplicationHCS { get; set; } = null!;
        public DbSet<ApplicationSP> ApplicationSP { get; set; } = null!;
        public DbStorage(DbContextOptions<DbStorage> options)
            : base(options) { Database.EnsureCreated(); }

        public void SaveChange() => SaveChanges();
    }
}
