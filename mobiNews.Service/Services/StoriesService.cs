using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Data.Models;

namespace mobiNews.Service.Services
{
    public class StoriesService : IStoriesService
    {
        public IEnumerable<NewStory> GetStories()
        {
            throw new NotImplementedException();
        }

        public NewStory GetStory(Func<NewStory, bool> param)
        {
            throw new NotImplementedException();
        }
    }
}
