using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieTheater.Data;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Commands.Contracts;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreatePdfReportCommand : ICommand
    {
        private readonly MovieTheaterDbContext dbContext;
        private readonly IExporter exporter;

        public CreatePdfReportCommand(MovieTheaterDbContext dbContext, IExporter exporter)
        {
            this.dbContext = dbContext;
            this.exporter = exporter;
        }

        public string Execute(List<string> parameters)
        {
            string reportName = parameters[0];

            var builder = new StringBuilder();
            this.dbContext.Theaters.ToList().ForEach(t => builder.AppendLine($"Theater: {t.Name}, Location: {t.City.Name}"));

            this.exporter.Export(builder.ToString(), parameters[0]);

            return $"Successfully created PDF file named {reportName}!";
        }
    }
}