using Autofac;
using MobiNews.Core.Handlers;
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

            return builder.Build();
        }
    }
}
