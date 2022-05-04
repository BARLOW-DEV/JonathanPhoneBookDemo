using LibraryDemo.EntityFrameworkCore;

namespace LibraryDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly LibraryDemoDbContext _context;

        public InitialHostDbBuilder(LibraryDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
