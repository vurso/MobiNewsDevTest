using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Interfaces
{
    public interface IXmlFtpDataHandler
    {
        NewsStory GetNewsStory();
        NewsStory GetNewsStory(string fileName);
    }
}
