using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Data.Models;
using MobiNews.Data.Repositories;

namespace mobiNews.Service.Services
{
    public class StoriesService : IStoriesService
    {
        private readonly INewStoryRepository _newStoryRepository;

        public StoriesService(INewStoryRepository newStoryRepository)
        {
            _newStoryRepository = newStoryRepository;
        }

        public IEnumerable<NewStory> GetStories()
        {
            return _newStoryRepository.GetNewStories();
        }

        public NewStory GetStory(Func<NewStory, bool> param)
        {
            throw new NotImplementedException();
        }
    }
}
