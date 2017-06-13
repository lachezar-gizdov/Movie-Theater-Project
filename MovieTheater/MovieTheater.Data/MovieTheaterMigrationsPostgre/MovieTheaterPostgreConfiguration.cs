namespace MovieTheater.Data.MovieTheaterMigrationsPostgre
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MovieTheaterPostgreConfiguration : DbMigrationsConfiguration<MovieTheater.Data.Contexts.MovieTheaterDbContextPostgre>
    {
        public MovieTheaterPostgreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MovieTheaterMigrationsPostgre";
        }

        protected override void Seed(MovieTheater.Data.Contexts.MovieTheaterDbContextPostgre context)
        {
            context.Departments.AddOrUpdate(
                d => d.Name,
                new Department { Name = "Sales" },
                new Department { Name = "Administration" },
                new Department { Name = "Management" },
                new Department { Name = "Maintenance" }
           );
        }
    }
}
