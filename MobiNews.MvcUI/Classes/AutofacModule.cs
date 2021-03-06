﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using mobiNews.Service.Services;
using MobiNews.Core.Handlers;
using MobiNews.Data;
using MobiNews.Data.Repositories;
using MobiNews.Web.Helpers;

namespace MobiNews.MvcUI.Classes
{
    public static class AutofacModule
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SupplierService>().As<ISupplierService>();
            builder.RegisterType<SupplierRepository>().As<ISupplierRepository>();
            builder.RegisterType<NewsStoryService>().As<INewStoryService>();
            builder.RegisterType<NewStoryRepository>().As<INewStoryRepository>();
            builder.RegisterType<StoriesService>().As<IStoriesService>();
            builder.RegisterType<MobiNewsContext>().AsSelf();
            builder.RegisterType<ImportMethodHelper>().As<IImportMethodHelper>();
            builder.RegisterType<JsonFileHandler>().As<IJsonFileHandler>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}