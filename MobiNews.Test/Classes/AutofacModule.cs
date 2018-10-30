using Autofac;
using mobiNews.Service.Services;
using MobiNews.Core.Handlers;
using MobiNews.Data;
using MobiNews.Data.Repositories;
using MobiNews.Web.Helpers;
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
            builder.RegisterType<NewStoryRepository>().As<INewStoryRepository>();
            builder.RegisterType<NewsStoryService>().As<INewStoryService>();
            builder.RegisterType<ImportMethodHelper>().As<IImportMethodHelper>();
            builder.RegisterType<MobiNewsContext>().AsSelf();

            return builder.Build();
        }
    }
}
