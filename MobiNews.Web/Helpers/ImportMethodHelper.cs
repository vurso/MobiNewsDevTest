using MobiNews.Core.Entities;
using MobiNews.Core.Enums;
using MobiNews.Core.Handlers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MobiNews.Web.Helpers
{
    public class ImportMethodHelper : IImportMethodHelper
    {
        private readonly IJsonFileHandler _jsonFileHandler;
        private const string IMPORTMETHODSJSONFILE = "ImportMethodsJsonFileName";

        public ImportMethodHelper(IJsonFileHandler jsonFileHandler)
        {
            _jsonFileHandler = jsonFileHandler;
        }

        public IEnumerable<SelectListItem> GetImportTypes()
        {
            var importTypesList = new List<SelectListItem>();

            var importTypeEnumValues = Enum.GetNames(typeof(ImportType)).ToList();

            foreach (var importType in importTypeEnumValues)
            {
                importTypesList.Add(new SelectListItem()
                {
                    Value = importType,
                    Text = importType
                });
            }

            return importTypesList;
        }

        public IEnumerable<SelectListItem> GetSelectListItemFromEnum<T>()
        {
            var importTypesList = new List<SelectListItem>();

            var importTypeEnumValues = Enum.GetNames(typeof(T)).ToList();

            for(int i = 0; i < importTypeEnumValues.Count; i++)
            {
                importTypesList.Add(new SelectListItem()
                {
                    Value = (i + 1).ToString(),
                    Text = importTypeEnumValues[i]
                });
            }

            return importTypesList;
        }

        public ImportMethodsJson LoadImportMethods()
        {
            ImportMethodsJson loadedImportMethods = null;

            var appBaseDir = AppDomain.CurrentDomain.BaseDirectory;
            if (Directory.Exists(appBaseDir))
            {
                try
                {
                    var filePath = Path.Combine(appBaseDir, ConfigurationManager.AppSettings.Get(IMPORTMETHODSJSONFILE));
                    if (File.Exists(filePath))
                    {
                        loadedImportMethods = _jsonFileHandler.LoadJsonFile<ImportMethodsJson>(filePath);
                    }
                }
                catch(FileLoadException)
                {
                    // log this
                }
            }

            return loadedImportMethods;
        }
    }
}
