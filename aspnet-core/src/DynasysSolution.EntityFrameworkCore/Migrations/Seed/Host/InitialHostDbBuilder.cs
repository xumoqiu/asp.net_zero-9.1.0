using DynasysSolution.EntityFrameworkCore;

namespace DynasysSolution.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly DynasysSolutionDbContext _context;

        public InitialHostDbBuilder(DynasysSolutionDbContext context)
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
