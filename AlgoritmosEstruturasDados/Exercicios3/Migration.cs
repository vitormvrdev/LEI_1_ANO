using Microsoft.EntityFrameworkCore;

namespace Exercicios3.Data
{
    public class ApllicationDbContext : DbContext
    {
        public ApllicationDbContext(DbContextOptions<ApllicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
