using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobiNews.MvcUI.Models
{
    public class NewStoriesModel
    {
        public List<Story> Stories { get; set; }

        // paging
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }

    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string NewsStory { get; set; }
        public string ImagePath { get; set; }
        public string Supplier { get; set; }
        public string Ref { get; set; }
        public DateTime DateAdded { get; set; }
    }
}