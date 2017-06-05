using Bytes2you.Validation;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core.Contracts;
using System;

namespace MovieTheater.Framework.Core
{
    public class Engine : IEngine
    {
        private const string LoggerCheck = "Engine Logger provider";
        private const string CommandParserCheck = "Engine Parser provider";

        private IParser commandParser;
        private IReader reader;
        private IWriter writer;

        public Engine(IParser commandParser, IReader reader, IWriter writer)
        {
            Guard.WhenArgument(commandParser, CommandParserCheck).IsNull().Throw();

            this.commandParser = commandParser;
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            while (true)
            {
                var fullCommand = reader.Read();

                if (fullCommand.ToLower() == "exit")
                {
                    writer.Write("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.commandParser.Process(fullCommand);
                    writer.Write(executionResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}