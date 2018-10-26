using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Data.Models;

namespace MobiNews.Data.Repositories
{
    public class NewStoryRepository : BaseRepository<MobiNewsContext>, INewStoryRepository
    {
        public NewStoryRepository(MobiNewsContext context) : base(context) { }

        public void Create(NewStory newStory)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewStory newStory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetNewStories()
        {
            throw new NotImplementedException();
        }

        public NewStory GetNewStory(Func<NewStory, bool> param)
        {
            throw new NotImplementedException();
        }

        public void Update(NewStory newStory)
        {
            throw new NotImplementedException();
        }
    }
}
