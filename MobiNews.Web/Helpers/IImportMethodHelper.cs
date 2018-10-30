using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MobiNews.Web.Helpers
{
    public interface IImportMethodHelper
    {
        IEnumerable<SelectListItem> GetImportTypes();
        IEnumerable<SelectListItem> GetSelectListItemFromEnum<T>();
    }
}
