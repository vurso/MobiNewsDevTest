namespace MobiNews.Core.Handlers
{
    public interface IDefinitionHandler
    {
        void Process<T>(T definition);
    }
}