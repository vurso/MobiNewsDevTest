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
        private string xmlFeedUri = "http://localhost:8080/Feedomatic3000";
        private PublishingXml _publishingXml;
        private ILifetimeScope _scope;
        private IXMLFeedDataHandler _xMLFeedDataHandler;

        [SetUp]
        public void SetUp()
        {
            using (var container = AutofacModule.Configure())
            {
                _scope = container.BeginLifetimeScope();

                _xMLFeedDataHandler = _scope.Resolve<IXMLFeedDataHandler>();
            }
        }

        [Test]
        public void Get_Valid_XmlDocument_Object_From_Xml_Feed_Data_Handler()
        {
            _publishingXml = _xMLFeedDataHandler.GetPublishingStories(xmlFeedUri);

            _publishingXml.Should().NotBeNull()
                .And.BeOfType<PublishingXml>()
                .Which.PublishingId.Equals(23);
        }
    }
}
