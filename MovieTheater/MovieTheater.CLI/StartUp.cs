using System.Data.Entity;
using MovieTheater.Data;
using MovieTheater.Data.Migrations;
using MovieTheater.Framework.Common;
using MovieTheater.Framework.Core;
using MovieTheater.Framework.Core.Commands;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Models.Factory;

namespace MovieTheater.CLI
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieTheaterDbContext, Configuration>());
            var data = new MovieTheaterDbContext();

            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var pdfExporter = new PdfExporter();
            var modelsFactory = new ModelsFactory();
            var fileReaderFactory = new FileReaderFactory(reader,writer);
            var commandsFactory = new CommandsFactory(data, modelsFactory, pdfExporter, fileReaderFactory);
            var commandParser = new CommandParser(commandsFactory);
            var engine = new Engine(commandParser, reader, writer);

            engine.Start();
        }
    }
}