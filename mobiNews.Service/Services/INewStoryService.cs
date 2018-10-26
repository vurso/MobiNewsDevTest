using MobiNews.Core.Dto;
using System;
using System.Collections;

namespace mobiNews.Service.Services
{
    public interface INewStoryService
    {
        void Create(NewsStory newStory);
        NewsStory GetNewStory(Func<NewsStory, bool> param);
        NewsStory FetchNewsStory();
        NewsStory FetchNewsStory(string fileName);
        IEnumerable GetNewStories();
        void Update(NewsStory newStory);
        void Delete(NewsStory newStory);
    }
}
