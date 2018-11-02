
namespace MobiNews.Core.Entities
{
    public class ImportMethodsJson
    {
        public Importmethod[] importMethods { get; set; }
    }

    public class Importmethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ImportType { get; set; }
        public Parameter[] Parameters { get; set; }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string Param { get; set; }
    }
}