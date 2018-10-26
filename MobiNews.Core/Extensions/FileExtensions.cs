using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Extensions
{
    public static class FileExtensions
    {
        public static void Rename(this string fileName, string newName)
        {
            // rename the file using the move method
            File.Move(fileName, newName);

            // delete the old file
            File.Delete(fileName);
        }
    }
}
