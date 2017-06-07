using System;
using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Core.Providers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
