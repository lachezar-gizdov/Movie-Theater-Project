namespace DataSQLite.YourDbMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using System.Linq;

    internal sealed class AwesomeConfig : DbMigrationsConfiguration<SQLDbContext>
    {
        public AwesomeConfig()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"YourDbMigrations";
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(DataSQLite.SQLDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
