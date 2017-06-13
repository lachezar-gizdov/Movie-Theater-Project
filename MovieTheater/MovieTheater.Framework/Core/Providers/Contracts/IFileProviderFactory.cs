using MovieTheater.Framework.Core.Providers;
using MovieTheater.Models;

namespace MovieTheater.Framework.Providers.Contracts
{
    public interface IFileProviderFactory
    {
        JsonReader CreateJsonReader();

        Theater CreateJsonParser(string jsonString);
    }
}