﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
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
            Context.NewStories.Add(newStory);
            Context.Entry(newStory).State = EntityState.Added;
            Context.SaveChanges();

        }

        public void Delete(NewStory newStory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewStory> GetNewStories()
        {
            return Context.NewStories;
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
