using Microsoft.Data.Entity;

namespace Module1.Models
{
    public class Module1Context : DbContext
    {
        private static bool _created = false;

        public Module1Context()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
