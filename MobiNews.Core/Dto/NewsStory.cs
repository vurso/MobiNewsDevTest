using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Dto
{
    public class NewsStory
    {
        public string Id { get; set; }
        public string TopTitle { get; set; }
        public string Body { get; set; }
        public string Imageloc { get; set; }
        public Supplier Supplier { get; set; }
    }

    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string NotificationUrl { get; set; }
    }
}
