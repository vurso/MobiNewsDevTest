using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using FluentAssertions;
using MobiNews.Test.Classes;
using MobiNews.Test.Enums;
using MobiNews.Web.Helpers;
using NUnit.Framework;

namespace MobiNews.Test.Unit_Tests
{
    public class ImportMethodHelperTests
    {
        private IImportMethodHelper _importMethodHelper;
        private ILifetimeScope _scope;

        [SetUp]
        public void SetUp()
        {
            using (var container = AutofacModule.Configure())
            {
                _scope = container.BeginLifetimeScope();

                _importMethodHelper = _scope.Resolve<IImportMethodHelper>();
            }
        }

        [Test]
        public void Get_ImportTypes_As_SelectListItem()
        {
            var importTypesSelectList = _importMethodHelper.GetSelectListItemFromEnum<ImportType>();

            importTypesSelectList.Should().NotBeNullOrEmpty().And.HaveCount(5);
        }
    }
}
