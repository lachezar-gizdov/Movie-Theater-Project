using System.Data.Entity;
using MovieTheater.Models;
using MovieTheater.Data.MovieTheaterMigrationsLite;
using MovieTheater.Data.Contracts;
using System;

namespace MovieTheater.Data.Contexts
{
    public class MovieTheaterDbContextLite : DbContext, IShopDbContext
    {
        public MovieTheaterDbContextLite()
            : base("MovieTheaterLite")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContextLite, MovieTheaterLiteConfiguration>(true));
        }

        public IDbSet<FoodShop> FoodShops { get; set; }

        public IDbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.OnFoodShopModelCreating(modelBuilder);
            this.OnFoodModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void OnFoodModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .HasKey(f => f.Id)
                .HasMany(f => f.Shops)
                .WithMany(sh => sh.Foods);

            modelBuilder.Entity<Food>()
                .Property(f => f.Name)
                 .IsRequired()
                .HasColumnType("nvarchar");
        }

        private void OnFoodShopModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodShop>()
                   .HasKey(sh => sh.Id)
                   .HasMany(sh => sh.Foods)
                   .WithMany(f => f.Shops);

            modelBuilder.Entity<FoodShop>()
                .Property(sh => sh.Name)
                 .IsRequired()
                .HasColumnType("nvarchar");
        }
    }
}
