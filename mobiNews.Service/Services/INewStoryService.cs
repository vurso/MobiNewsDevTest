using MobiNews.Data.Models;
using System;
using System.Collections;

namespace mobiNews.Service.Services
{
    public interface INewStoryService
    {
        void Create(NewStory newStory);
        NewStory GetNewStory(Func<NewStory, bool> param);
        IEnumerable GetNewStories();
        void Update(NewStory newStory);
        void Delete(NewStory newStory);
    }
}
