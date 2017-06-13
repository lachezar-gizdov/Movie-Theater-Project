using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieTheater.Framework.Common.Contracts;
using MovieTheater.Framework.Core;
using MovieTheater.Framework.Core.Providers.Contracts;
using Telerik.JustMock;

namespace MovieTheater.Tests.Framework.Tests.Core
{
    [TestClass]
    public class EngineShould
    {
        [TestMethod]
        public void ThrowWhenNullPassedAsCommandParser()
        {
            // Arrange
            IReader readerMock = Mock.Create<IReader>();
            IWriter writerMock = Mock.Create<IWriter>();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(null, readerMock, writerMock));
        }

        [TestMethod]
        public void ThrowWhenNullPassedAsReader()
        {
            // Arrange
            IParser commandsParserMock = Mock.Create<IParser>();
            IWriter writerMock = Mock.Create<IWriter>();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(commandsParserMock, null, writerMock));
        }

        [TestMethod]
        public void ThrowWhenNullPassedAsWriter()
        {
            // Arrange
            IParser commandsParserMock = Mock.Create<IParser>();
            IReader readerMock = Mock.Create<IReader>();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(commandsParserMock, readerMock, null));
        }
    }
}