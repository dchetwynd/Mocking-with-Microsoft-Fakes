using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadingFiles
{
    public class FileSystem: IFileSystem
    {
        public string ReadAllText(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
