using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.Context
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly();
        //    new DatabaseContextSeed().Seed(modelBuilder);
        //}
    }
}