using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Handlers
{
    /// <summary>
    /// Base class for the XML Handlers
    /// </summary>
    public class XmlHandlerBase
    {
        public readonly string FTPDIRPATHKEY = "FtpFolderPath";
        public readonly string IMAGEPATHKEY = "ServerImagePath";
        public readonly string XMLFEEDURIKEY = "XmlFeedUriKey";
        public readonly string XMLEXTENSION = ".xml";
    }
}
