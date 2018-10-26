using MobiNews.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Handlers
{
    public class XMLFeed : XmlHandlerBase, IXMLFeed
    {
        public XMLFeed()
        {
        }

        //public Publishing GetXmlFeedData(string xmlfeedPath)
        //{
        //    var publishedStories = new Publishing();

        //    // use HttpRequest to call the URL
        //    // consume the xml data
        //    // inflate the entity
        //    // loop through the stories and add story to the Publishing collection

        //    return publishedStories;
        //}
    }
}
