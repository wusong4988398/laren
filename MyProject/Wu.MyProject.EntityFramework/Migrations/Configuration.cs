using System.Data.Entity.Migrations;
using Wu.MyProject.Migrations.SeedData;
using Wu.MyProject.People;

namespace Wu.MyProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyProject.EntityFramework.MyProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyProject";
        }

        protected override void Seed(MyProject.EntityFramework.MyProjectDbContext context)
        {
            new InitialDataBuilder(context).Build();
            context.People.AddOrUpdate(
            p => p.Name,
            new Person { Name = "Isaac Asimov" },
            new Person { Name = "Thomas More" },
            new Person { Name = "George Orwell" },
            new Person { Name = "Douglas Adams" }
            );
        }
    }
}
