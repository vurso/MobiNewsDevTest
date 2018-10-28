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
    public class NewsStoryService : INewStoryService
    {
        private readonly IXmlFtpDataHandler _xmlFtpDataHandler;

        public NewsStoryService(IXmlFtpDataHandler xmlFtpDataHandler)
        {
            _xmlFtpDataHandler = xmlFtpDataHandler;
        }

        public void Create(NewsStory newStory)
        {
            throw new NotImplementedException();
        }

        public NewsStory FetchNewsStory()
        {
            return _xmlFtpDataHandler.GetNewsStory().MapXmlDataToDto();
        }

        public NewsStory FetchNewsStory(string fileName)
        {
            return _xmlFtpDataHandler.GetNewsStory(fileName).MapXmlDataToDto();
        }

        public void Update(NewsStory newStory)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewsStory newStory)
        {
            throw new NotImplementedException();
        }
    }
}
