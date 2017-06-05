using MovieTheater.Framework.Core.Contracts;
using System;

namespace MovieTheater.Framework.Core.Providers
{
    public class ConsoleReader : IReader
    {
        public virtual string Read()
        {
            return Console.ReadLine();
        }
    }
}