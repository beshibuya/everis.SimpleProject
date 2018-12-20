using everis.SimpleProject.Data.Context;

namespace everis.SimpleProject.Data.UnitOfWork
{
    public sealed class DatabaseUnitOfWork : IDatabaseUnitOfWork
    {
        public DatabaseUnitOfWork(DatabaseContext context)
        {
            Context = context;
        }

        private DatabaseContext Context { get; }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}