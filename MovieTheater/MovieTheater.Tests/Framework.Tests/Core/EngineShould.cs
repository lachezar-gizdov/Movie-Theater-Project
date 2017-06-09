using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieTheater.Framework.Core;
using MovieTheater.Framework.Core.Providers.Contracts;
using System;
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
            Assert.ThrowsException<Exception>(() => new Engine(null, readerMock, writerMock));
        }
    }
}