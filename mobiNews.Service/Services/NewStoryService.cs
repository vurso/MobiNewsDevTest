using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Core.Dto;
using MobiNews.Core.Extensions;
using MobiNews.Core.Handlers;

namespace mobiNews.Service.Services
{
    public class NewStoryService : INewStoryService
    {
        private readonly IXmlFtpDataHandler _xmlFtpDataHandler;

        public NewStoryService(IXmlFtpDataHandler xmlFtpDataHandler)
        {
            _xmlFtpDataHandler = xmlFtpDataHandler;
        }

        public void Create(NewsStory newStory)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewsStory newStory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetNewStories()
        {
            throw new NotImplementedException();
        }

        public NewsStory GetNewStory(Func<NewsStory, bool> param)
        {
            throw new NotImplementedException();
        }

        public NewsStory FetchNewsStory()
        {
            return _xmlFtpDataHandler.GetNewsStory().MapXmlDataToDto();
        }

        public void Update(NewsStory newStory)
        {
            throw new NotImplementedException();
        }

        public NewsStory FetchNewsStory(string fileName)
        {
            return _xmlFtpDataHandler.GetNewsStory(fileName).MapXmlDataToDto();
        }
    }
}
