using System;
using MovieTheater.Framework.Core.Contracts;

namespace MovieTheater.Framework.Core.Providers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
