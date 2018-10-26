using MobiNews.Data.Models;
using System;
using System.Collections;

namespace MobiNews.Data.Repositories
{
    public interface INewStoryRepository
    {
        void Create(NewStory newStory);
        NewStory GetNewStory(Func<NewStory, bool> param);
        IEnumerable GetNewStories();
        void Update(NewStory newStory);
        void Delete(NewStory newStory);
    }
}
