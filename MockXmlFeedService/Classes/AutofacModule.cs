using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockXmlFeedService.Classes
{
    public static class AutofacModule
    {
        public static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<XmlFeedProvider>().As<IXmlFeedProvider>();

            return builder.Build();
        }
    }
}
