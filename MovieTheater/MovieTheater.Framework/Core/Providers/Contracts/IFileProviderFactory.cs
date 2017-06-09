namespace MovieTheater.Framework.Providers.Contracts
{
    public interface IFileProviderFactory
    {
        string CreateJsonReader();

        void CreateJsonParser(string jsonString);
    }
}