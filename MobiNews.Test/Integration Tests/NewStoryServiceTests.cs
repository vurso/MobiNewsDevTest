using System;
using System.IO;
using System.Xml;
using Autofac;
using FluentAssertions;
using mobiNews.Service.Services;
using MobiNews.Core.Dto;
using MobiNews.Test.Classes;
using NUnit.Framework;

namespace MobiNews.Test.Integration_Tests
{
    public class NewStoryServiceTests
    {
        private string xmlTestFile;
        private NewsStory _newsStory;
        private ILifetimeScope _scope;
        private INewStoryService _newStoryService;

        [SetUp]
        public void SetUp()
        {
            xmlTestFile = FileBuilder();
            using (var container = AutofacModule.Configure())
            {
                _scope = container.BeginLifetimeScope();

                _newStoryService = _scope.Resolve<INewStoryService>();
            }
        }

        [Test]
        public void Get_NewsStory_Object_From_NewStory_Service()
        {
            _newsStory = _newStoryService.FetchNewsStory(xmlTestFile);

            _newsStory.Should().NotBeNull().And.BeOfType<NewsStory>().Which.Id.Equals("Apples_64");
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
