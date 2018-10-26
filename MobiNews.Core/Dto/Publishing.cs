using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Dto
{
    public class Publishing
    {
        public int PublishingId { get; set; }
        public IEnumerable<Story> PublishingStory { get; set; }
    }

    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string NewStoryText { get; set; }
        public string Image { get; set; }
    }
}
