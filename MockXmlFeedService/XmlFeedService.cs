using MockXmlFeedService.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Xml;
using System.Web.Services;

namespace MockXmlFeedService
{
    public class XmlFeedService
    {
        private XmlDocument mockXmlData;

        [WebMethod]
        public XmlDocument GetXmlFeed()
        {
            var container = AutofacModule.RegisterDependencies();

            using (var scope = container.BeginLifetimeScope())
            {
                var _xmlFeedProvider = scope.Resolve<IXmlFeedProvider>();

                mockXmlData = _xmlFeedProvider.GenerateMockXmlFeedData();
            }

            return mockXmlData;
        }
    }
}
