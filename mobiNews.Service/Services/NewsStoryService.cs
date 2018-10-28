using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Core.Dto;
using MobiNews.Core.Extensions;
using MobiNews.Core.Handlers;
using MobiNews.Data.Models;
using MobiNews.Data.Repositories;

namespace mobiNews.Service.Services
{
    public class NewsStoryService : INewStoryService
    {
        private readonly IXmlFtpDataHandler _xmlFtpDataHandler;
        private readonly INewStoryRepository _newStoryRepository;

        public NewsStoryService(IXmlFtpDataHandler xmlFtpDataHandler, INewStoryRepository newStoryRepository)
        {
            _xmlFtpDataHandler = xmlFtpDataHandler;
            _newStoryRepository = newStoryRepository;
        }

        public void Create(NewsStory newsStory)
        {
            var newStory = new NewStory()
            {
                Title = newsStory.TopTitle,
                NewsStory = newsStory.Body,
                ImagePath = newsStory.Imageloc,
                SupplierID = newsStory.Supplier.SupplierId,
                SupplierStoryRef = $"{newsStory.Id}",
                AddedDateTime = DateTime.Now
            };

            _newStoryRepository.Create(newStory);
        }

        public NewsStory FetchNewsStory()
        {
            return _xmlFtpDataHandler.GetNewsStory().MapXmlDataToDto();
        }

        public NewsStory FetchNewsStory(string fileName)
        {
            return _xmlFtpDataHandler.GetNewsStory(fileName).MapXmlDataToDto();
        }

        public void Update(NewsStory newsStory)
        {
            throw new NotImplementedException();
        }

        public void Delete(NewsStory newsStory)
        {
            throw new NotImplementedException();
        }
    }
}
