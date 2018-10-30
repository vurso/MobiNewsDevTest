using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobiNews.MvcUI.Models
{
    public class ImportTypeModel
    {
        [Display(Name = "")]
        public int SelectedImportType { get; set; }
        public IEnumerable<SelectListItem> ImportTypes { get; set; }
    }
}