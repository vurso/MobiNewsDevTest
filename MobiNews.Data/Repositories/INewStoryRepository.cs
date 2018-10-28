using MobiNews.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MobiNews.Data.Repositories
{
    public interface INewStoryRepository
    {
        void Create(NewStory newStory);
        NewStory GetNewStory(Func<NewStory, bool> param);
        IEnumerable<NewStory> GetNewStories();
        void Update(NewStory newStory);
        void Delete(NewStory newStory);
    }
}
