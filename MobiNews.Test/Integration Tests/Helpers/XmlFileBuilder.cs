using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Test.Integration_Tests.Helpers
{
    public static class XmlFileBuilder
    {
        public static string FileBuilder()
        {
            string xmlFileContents = "<?xml version=\"1.0\" ?><NewsStory> <id>Apples_64</id> <topTitle>Apple eaten by Large Tech Firm</topTitle> " +
                "<body>All staff agreed that the fruit was very tasty indeed and could not understand why it had been previously " +
                "banned within the office.</body> <imageloc>apple.jpg</imageloc> </NewsStory>";

            // generate a random file name then use that to create the test xml file
            // this process can be monitored by opening the temp file path and viewing the file creation process
            var randomFileName = GenerateRandomFileName();
            var fileName = $"{Path.GetTempPath()}{randomFileName}.xml";
            File.WriteAllText(fileName, xmlFileContents);

            return fileName;
        }

        public static string GenerateRandomFileName()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }
    }
}
