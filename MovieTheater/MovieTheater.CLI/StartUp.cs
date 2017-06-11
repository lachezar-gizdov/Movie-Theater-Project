using System.Data.Entity;
using MovieTheater.CLI.NinjectModules;
using MovieTheater.Data.Contexts;
using MovieTheater.Data.Migrations;
using MovieTheater.Framework.Core.Contracts;
using Ninject;
using MovieTheater.Models;

namespace MovieTheater.CLI
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContext, Configuration>());


            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContextLite, ConfigurationLite>());
            //var data2 = new MovieTheaterDbContextLite();
            //var foodShop = new FoodShop() { Name = "KFC" };
            //data2.FoodShops.Add(foodShop);
            //data2.SaveChanges();


            IKernel kernel = new StandardKernel(new MovieTheaterModule());
            IEngine engine = kernel.Get<IEngine>();

            engine.Start();
        }
    }
}