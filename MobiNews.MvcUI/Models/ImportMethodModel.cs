using MobiNews.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobiNews.MvcUI.Models
{
    public class ImportMethodModel
    {
        public ImportMethod ImportMethod { get; set; }
        public List<ImportMethod> ImportMethods { get; set; }
        public List<SelectListItem> ImportTypes { get; set; }
    }

    public class ImportMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ImportType ImportType { get; set; }
        public List<Parameter> Parameters { get; set; }

        public string ListParametersHtmlFormat
        {
            get
            {
                var outerStartParamterString = "<ul>";
                var bodyParameterString = string.Empty;
                var outerEndParamterString = "</ul>";
                var result = string.Empty;

                foreach(var param in Parameters)
                {
                    bodyParameterString += $"<li>Param name: {param.Name}, Parameter: {param.Param}</li>";
                }

                result = $"{outerStartParamterString}{bodyParameterString}{outerEndParamterString}";

                return result;
            }
        }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string Param { get; set; }
    }
}