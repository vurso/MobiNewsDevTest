using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MobiNews.Core.Extensions
{
    public static class XmlFeedDataExtensions
    {
        /// <summary>
        /// Deserializes XmlDocument object to Serializable object of type T.
        /// </summary>
        /// <typeparam name="T">Serializable object type as output type.</typeparam>
        /// <param name="document">XmlDocument object to be deserialized.</param>
        /// <returns>Deserialized serializable object of type T.</returns>
        public static T Deserialize<T>(this XmlDocument document)
            where T : class
        {
            XmlReader reader = new XmlNodeReader(document);
            var serializer = new XmlSerializer(typeof(T));
            T result = (T)serializer.Deserialize(reader);
            return result;
        }
    }
}
