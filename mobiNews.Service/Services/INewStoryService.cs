using MobiNews.Core.Dto;
using System;
using System.Collections;

namespace mobiNews.Service.Services
{
    public interface INewStoryService
    {
        void Create(NewsStory newStory);
        NewsStory FetchNewsStory();
        NewsStory FetchNewsStory(string fileName);
        void Update(NewsStory newStory);
        void Delete(NewsStory newStory);
    }
}
