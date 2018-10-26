using MobiNews.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobiNews.MvcUI.Models
{
    public class SupplierModel
    {
        // view model properties
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string NotificationUrl { get; set; }
        public List<Supplier> Suppliers { get; set; }

        // paging
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        // Data
        public string FeedURL { get; set; }
        public string FTPPath { get; set; }
    }
}