using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MobiNews.Core.Definitions;
using MobiNews.Core.Handlers;
using MobiNews.Test.Classes;
using MockXmlFeedService;
using NUnit.Framework;

namespace MobiNews.Test.Unit_Tests
{
    public class DefinitionHandlerTests
    {
        private IDefinitionHandler _definitionHandler;
        private ILifetimeScope _scope;
        private IXmlFeedService _xmlFeedService;
        private IUrlDefinition _urlDefinition;


        [SetUp]
        public void SetUp()
        {
            using (var container = AutofacModule.Configure())
            {
                _scope = container.BeginLifetimeScope();

                _definitionHandler = _scope.Resolve<IDefinitionHandler>();
                _xmlFeedService = _scope.Resolve<IXmlFeedService>();
                _urlDefinition = _scope.Resolve<IUrlDefinition>();
            }
        }

        [Test]
        public void Execute_Process_Method_For_Given_Type()
        {
            _definitionHandler.Process(_urlDefinition);
        }
    }
}
