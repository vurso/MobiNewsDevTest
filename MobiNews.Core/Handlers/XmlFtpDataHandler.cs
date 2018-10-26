using MobiNews.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MobiNews.Core.Handlers
{
    public class XmlFtpDataHandler : XmlHandlerBase, IXmlFtpDataHandler
    {
        private NewsStoryXml newsStory;

        public XmlFtpDataHandler()
        {
        }

        public NewsStoryXml GetNewsStory()
        {
            // get the directory path
            var directory = ConfigurationManager.AppSettings.Get(FTPDIRPATHKEY);

            // check if it exists
            if (!string.IsNullOrEmpty(directory))
            {
                if(!Directory.Exists(directory))
                {
                    // doesn't exist so return an error
                    // log this
                    return newsStory;
                }

                ProcessDirectory(directory);
            }

            return newsStory;
        }

        public NewsStoryXml GetNewsStory(string fileName)
        {
            ProcessFile(fileName);

            return newsStory;
        }

        private void ProcessDirectory(string directory)
        {
            string[] fileEntries = Directory.GetFiles(directory);
            foreach (var fileName in fileEntries)
                ProcessFile(fileName);
        }

        private void ProcessFile(string fileName)
        {
            var fileExtension = Path.GetExtension(fileName);
            var imageDirectory = ConfigurationManager.AppSettings.Get(IMAGEPATHKEY);

            if (fileExtension.ToLower() == XMLEXTENSION)
            {
                try
                {
                    // its an XML file so get contents and inflate the entity
                    var xmlSerializer = new XmlSerializer(typeof(NewsStoryXml));
                    using (var fs = new FileStream(fileName, FileMode.Open))
                    {
                        newsStory = (NewsStoryXml)xmlSerializer.Deserialize(fs);
                    }

                    //File.Delete(fileName);

                    return;
                }
                catch(XmlException /*xex*/)
                {
                    // log this
                }
            }

            if(fileName.IsRecognisedImageFile())
            {
                // copy the file to the server image path
                if(!Directory.Exists(imageDirectory))
                {
                    Directory.CreateDirectory(imageDirectory);
                }

                File.Copy(fileName, $"{imageDirectory}\\{fileName}");

                // delete the existing file
                File.Delete(fileName);

                return;
            }
        }
    }
}
