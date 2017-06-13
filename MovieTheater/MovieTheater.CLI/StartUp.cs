using MovieTheater.CLI.NinjectModules;
using MovieTheater.Framework.Core.Contracts;
using Ninject;

namespace MovieTheater.CLI
{
    public class StartUp
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new MovieTheaterModule());
            IEngine engine = kernel.Get<IEngine>();

            engine.Start();
        }
    }
}