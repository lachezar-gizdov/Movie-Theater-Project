using MovieTheater.Framework.Common;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core;
using MovieTheater.Framework.Core.Commands;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Framework.Core.Contracts;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Core.Providers.Contracts;
using MovieTheater.Framework.Providers;
using MovieTheater.Framework.Providers.Contracts;
using MovieTheater.Models.Factory;
using MovieTheater.Models.Factory.Contracts;
using Ninject.Modules;

namespace MovieTheater.CLI.NinjectModules
{
    public class MovieTheaterModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<IExporter>().To<PdfExporter>();
            this.Bind<IModelsFactory>().To<ModelsFactory>();
            this.Bind<IFileProviderFactory>().To<FileProviderFactory>();
            this.Bind<ICommandsFactory>().To<CommandsFactory>();
            this.Bind<IParser>().To<CommandParser>();
            this.Bind<IEngine>().To<Engine>();
        }
    }
}
