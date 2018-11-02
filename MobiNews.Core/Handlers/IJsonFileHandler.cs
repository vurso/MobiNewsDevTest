namespace MobiNews.Core.Handlers
{
    public interface IJsonFileHandler
    {
        T LoadJsonFile<T>(string filePath);
    }
}