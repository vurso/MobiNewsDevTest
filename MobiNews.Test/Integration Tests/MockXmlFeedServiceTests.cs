using System;
using System.IO;
using System.Xml;
using Autofac;
using FluentAssertions;
using MobiNews.Core.Handlers;
using MobiNews.Test.Classes;
using MockXmlFeedService;
using NUnit.Framework;

namespace MobiNews.Test.Integration_Tests
{
    public class MockXmlFeedServiceTests
    {
        private XmlDocument _xmlDocument;
        private ILifetimeScope _scope;
        private IXmlFeedProvider _xmlFeedProvider;

        [SetUp]
        public void SetUp()
        {
            using (var container = AutofacModule.Configure())
            {
                _scope = container.BeginLifetimeScope();

                _xmlFeedProvider = _scope.Resolve<IXmlFeedProvider>();
            }
        }

        [Test]
        public void Get_Valid_XmlDocument_Object_From_Mock_Service()
        {
            _xmlDocument = _xmlFeedProvider.GenerateMockXmlFeedData();

            _xmlDocument.Should().NotBeNull().And
                .BeOfType<XmlDocument>().Which
                .FirstChild.InnerText
                .Equals("version=\"1.0\" encoding=\"utf - 16\"");
        }
    }
}
