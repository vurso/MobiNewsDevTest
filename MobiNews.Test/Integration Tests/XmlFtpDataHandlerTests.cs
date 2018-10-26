using System;
using System.IO;
using Autofac;
using FluentAssertions;
using MobiNews.Core.Handlers;
using MobiNews.Test.Classes;
using MobiNews.Test.Integration_Tests.Helpers;
using NUnit.Framework;

namespace MobiNews.Test.Integration_Tests
{
    public class XmlFtpDataHandlerTests
    {
        private string xmlTestFile;
        private const string TESTID = "Apples_64";
        private NewsStoryXml _newsStory;
        private ILifetimeScope _scope;
        private IXmlFtpDataHandler _xmlFtpDataHandler;

        [SetUp]
        public void SetUp()
        {
            xmlTestFile = XmlFileBuilder.FileBuilder();
            using (var container = AutofacModule.Configure())
            {
                _scope = container.BeginLifetimeScope();

                _xmlFtpDataHandler = _scope.Resolve<IXmlFtpDataHandler>();
            }
        }

        [TearDown]
        public void Teardown()
        {
            if(File.Exists(xmlTestFile))
            {
                File.Delete(xmlTestFile);
            }
        }

        [Test]
        public void Given_Valid_Xml_Test_File_Inflate_NewsStory_Entity()
        {
            _newsStory = _xmlFtpDataHandler.GetNewsStory(xmlTestFile);

            _newsStory.Should().NotBeNull().And.BeOfType<NewsStoryXml>();
            _newsStory.Id.Should().NotBeNull().And.Match(TESTID);
        }
    }
}
