using MovieTheater.Framework.Core.Providers.Contracts;

namespace MovieTheater.Framework.Common.Contracts
{
    public interface IFileReaderFactory
    {
        string CreateJsonReader();
    }
}