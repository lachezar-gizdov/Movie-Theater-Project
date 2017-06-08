namespace MovieTheater.Framework.Common.Contracts
{
    public interface IExporter
    {
        void Export(string textToExport, string fileName);
    }
}