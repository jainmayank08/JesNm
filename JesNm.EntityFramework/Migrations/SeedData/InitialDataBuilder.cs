using JesNm.EntityFramework;
using EntityFramework.DynamicFilters;

namespace JesNm.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly JesNmDbContext _context;

        public InitialDataBuilder(JesNmDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
