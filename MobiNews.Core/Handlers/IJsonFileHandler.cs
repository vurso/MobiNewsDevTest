namespace MobiNews.Core.Handlers
{
    public interface IJsonFileHandler
    {
        T LoadJsonFile<T>(string filePath);
        void WriteJsonFile<T>(T jsonData, string filePath);
    }
}