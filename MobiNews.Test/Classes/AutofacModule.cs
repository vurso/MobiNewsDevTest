using Autofac;
using mobiNews.Service.Services;
using MobiNews.Core.Handlers;
using MockXmlFeedService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Test.Classes
{
    public static class AutofacModule
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // register any types here
            builder.RegisterType<XmlFtpDataHandler>().As<IXmlFtpDataHandler>();
            builder.RegisterType<XmlFeedProvider>().As<IXmlFeedProvider>();
            builder.RegisterType<XMLFeedDataHandler>().As<IXMLFeedDataHandler>();
            builder.RegisterType<XmlFeedService>().As<IXmlFeedService>();
            builder.RegisterType<NewsStoryService>().As<INewStoryService>();

            return builder.Build();
        }
    }
}
