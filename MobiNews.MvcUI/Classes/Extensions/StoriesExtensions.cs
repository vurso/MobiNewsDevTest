using MobiNews.Data.Models;
using MobiNews.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.MvcUI.Classes.Extensions
{
    public static class StoriesExtensions
    {
        public static Story MapNewStoryToStory(this NewStory newStory)
        {
            Story story;

            if(newStory == null || newStory.NewsStoryID <= 0)
            {
                return new Story();
            }

            try
            {
                story = new Story()
                {
                    Id = newStory.NewsStoryID,
                    Title = newStory.Title,
                    NewsStory = newStory.NewsStory,
                    ImagePath = newStory.ImagePath,
                    Supplier = newStory.Supplier.SupplierName,
                    Ref = newStory.SupplierStoryRef,
                    DateAdded = newStory.AddedDateTime
                };

                return story;
            }
            catch(Exception /*ex*/)
            {
                return story = new Story();
            }
        }

        public static List<Story> MapNewStoriesToStories(this IEnumerable<NewStory> stories)
        {
            var newStories = new List<Story>();

            if(stories != null && stories.Count() > 0)
            {
                foreach(var story in stories)
                {
                    newStories.Add(story.MapNewStoryToStory());
                }
            }

            return newStories;
        }
    }
}
