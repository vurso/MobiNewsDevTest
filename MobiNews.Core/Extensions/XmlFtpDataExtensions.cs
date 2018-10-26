using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Extensions
{
    public static class XmlFtpDataExtensions
    {
        public static Dto.NewsStory MapXmlDataToDto(this NewsStoryXml newsStoryXml)
        {
            Dto.NewsStory newsStory;

            // check if we actually have some valid data to work with
            if(newsStoryXml == null || string.IsNullOrEmpty(newsStoryXml.Id))
            {
                return newsStory = new Dto.NewsStory();
            }

            // try mapping the data to the new dto object
            try
            {
                newsStory = new Dto.NewsStory()
                {
                    Id = newsStoryXml.Id,
                    TopTitle = newsStoryXml.TopTitle,
                    Body = newsStoryXml.Body,
                    Imageloc = newsStoryXml.Imageloc
                };
            }
            catch(Exception /*ex*/)
            {
                // log this
                newsStory = new Dto.NewsStory();
            }

            return newsStory;
        }
    }
}
