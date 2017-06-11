using MovieTheater.Framework.Core.Providers;

namespace MovieTheater.Framework.Providers.Contracts
{
    public interface IFileProviderFactory
    {
        JsonReader CreateJsonReader();

        void CreateJsonParser(string jsonString);
    }
}