using MovieTheater.Framework.Core.Contracts;
using System;

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
