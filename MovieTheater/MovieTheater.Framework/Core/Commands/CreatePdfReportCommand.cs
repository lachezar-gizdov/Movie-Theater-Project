using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreatePdfReportCommand : Command, ICommand
    {
        private readonly IExporter exporter;

        public CreatePdfReportCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory, IExporter exporter) : 
            base(dbContext, modelsFactory)
        {
            this.exporter = exporter;
        }

        public override string Execute(List<string> parameters)
        {
            string reportName = parameters[0];

            var builder = new StringBuilder();
            this.DbContext.Theaters.ToList().ForEach(t => builder.AppendLine($"Theater: {t.Name}, Location: {t.City.Name}"));

            this.exporter.Export(builder.ToString(), parameters[0]);

            return $"Successfully created PDF file named {reportName}!";
        }
    }
}