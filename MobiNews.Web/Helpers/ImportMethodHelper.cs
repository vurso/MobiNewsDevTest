using MobiNews.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MobiNews.Web.Helpers
{
    public class ImportMethodHelper : IImportMethodHelper
    {
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
    }
}
