using System;
using System.IO;
using System.Xml;
using Autofac;
using FluentAssertions;
using MobiNews.Core.Handlers;
using MobiNews.Test.Classes;
using NUnit.Framework;

namespace MobiNews.Test.Integration_Tests
{
    public class XmlFeedDataHandlerTests
    {
        private string mockXmlData;
        private XmlDocument _xmlDocument;
        private ILifetimeScope _scope;
        private IXMLFeedDataHandler _xMLFeedDataHandler;

        [SetUp]
        private void SetUp()
        {
            
        }
    }
}
