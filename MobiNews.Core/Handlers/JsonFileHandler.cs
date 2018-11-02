using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Handlers
{
    public class JsonFileHandler : JsonHandlerBase, IJsonFileHandler
    {
        public JsonFileHandler()
        {
        }

        public T LoadJsonFile<T>(string filePath)
        {
            T result = default(T);

            if(File.Exists(filePath))
            {
                // try to deserialize the file data
                try
                {
                    var jsonData = File.ReadAllText(filePath);
                    result = JsonConvert.DeserializeObject<T>(jsonData);

                }
                catch(Exception)
                {
                    return result;
                }
            }

            return result;
        }
    }
}
