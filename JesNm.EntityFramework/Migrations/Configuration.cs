using System.Data.Entity.Migrations;
using JesNm.Migrations.SeedData;

namespace JesNm.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<JesNm.EntityFramework.JesNmDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "JesNm";
        }

        protected override void Seed(JesNm.EntityFramework.JesNmDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
