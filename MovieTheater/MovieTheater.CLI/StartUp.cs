using System.Data.Entity;
using MovieTheater.Data;
using MovieTheater.Data.Migrations;
using MovieTheater.Framework.Core.Contracts;
using MovieTheater.CLI.NinjectModules;
using Ninject;

namespace MovieTheater.CLI
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContext, Configuration>());
            var data = new MovieTheaterDbContext();

            IKernel kernel = new StandardKernel(new MovieTheaterModule());

            //var reader = new ConsoleReader();
            //var writer = new ConsoleWriter();
            //var pdfExporter = new PdfExporter();
            //var modelsFactory = new ModelsFactory();
            //var fileProviderFactory = new FileProviderFactory(reader,writer);
            //var commandsFactory = new CommandsFactory(data, modelsFactory, pdfExporter, fileProviderFactory);
            //var commandParser = new CommandParser(commandsFactory);
            // var engine = new Engine(commandParser, reader, writer);

            IEngine engine = kernel.Get<IEngine>();

            engine.Start();
        }
    }
}