using MobiNews.Core.Entities;
using MobiNews.Core.Enums;
using MobiNews.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobiNews.MvcUI.Classes.Extensions
{
    public static class ImportMethodsExtensions
    {
        public static IEnumerable<ImportMethods> MapJsonImportMethodsToModel( this Importmethod[] inportMethodsJsonData)
        {
            List<ImportMethods> importMethods = new List<ImportMethods>();

            foreach(var importMethodJsonData in inportMethodsJsonData)
            {
                importMethods.Add(new ImportMethods()
                {
                    Id = importMethodJsonData.Id,
                    Name = importMethodJsonData.Name,
                    ImportType = (ImportType)importMethodJsonData.ImportType,
                    Parameters = MapJsonParamterToModelParamter(importMethodJsonData.Parameters)
                });
            }

            return importMethods;
        }
        private static List<Models.Parameter> MapJsonParamterToModelParamter(Core.Entities.Parameter[] parameters)
        {
            var importMethodParameters = new List<Models.Parameter>();

            if(parameters != null && parameters.Count() > 0)
            {
                foreach(var param in parameters)
                {
                    importMethodParameters.Add(new Models.Parameter()
                    {
                        Name = param.Name,
                        Param = param.Param
                    });
                }
            }

            return importMethodParameters;
        }
    }
}