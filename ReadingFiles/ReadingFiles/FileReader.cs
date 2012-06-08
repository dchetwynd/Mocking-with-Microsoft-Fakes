using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFiles
{
    public static class FileReader
    {
        public static bool IsFileEmpty(IFileSystem fileSystem, string fileName)
        {
            var fileContents = fileSystem.ReadAllText(fileName);
            return string.IsNullOrEmpty(fileContents);
        }
    }
}
