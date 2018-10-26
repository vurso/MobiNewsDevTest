using System;
using System.IO;
using System.Xml;
using Autofac;
using FluentAssertions;
using mobiNews.Service.Services;
using MobiNews.Core.Dto;
using MobiNews.Test.Classes;
using MobiNews.Test.Integration_Tests.Helpers;
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
            xmlTestFile = XmlFileBuilder.FileBuilder();
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
    }
}
