using System;
using System.IO;
using Autofac;
using FluentAssertions;
using MobiNews.Core.Handlers;
using MobiNews.Core.Interfaces;
using MobiNews.Test.Classes;
using NUnit.Framework;

namespace MobiNews.Test.Integration_Tests
{
    public class XmlFtpDataHandlerTests
    {
        private string xmlTestFile;
        private const string TESTID = "Apples_64";
        private NewsStory _newsStory;
        private ILifetimeScope _scope;
        private IXmlFtpDataHandler _xmlFtpDataHandler;

        [SetUp]
        public void SetUp()
        {
            xmlTestFile = FileBuilder();
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

            _newsStory.Should().NotBeNull().And.BeOfType<NewsStory>();
            _newsStory.Id.Should().NotBeNull().And.Match(TESTID);
        }

        private string FileBuilder()
        {
            string xmlFileContents = "<?xml version=\"1.0\" ?><NewsStory> <id>Apples_64</id> <topTitle>Apple eaten by Large Tech Firm</topTitle> " +
                "<body>All staff agreed that the fruit was very tasty indeed and could not understand why it had been previously " +
                "banned within the office.</body> <imageloc>apple.jpg</imageloc> </NewsStory>";

            // generate a random file name then use that to create the test xml file
            // this process can be monitored by opening the temp file path and viewing the file creation process
            var randomFileName = GenerateRandomFileName();
            var fileName = $"{Path.GetTempPath()}{randomFileName}.xml";
            File.WriteAllText(fileName, xmlFileContents);

            return fileName;
        }

        private string GenerateRandomFileName()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }
    }
}
