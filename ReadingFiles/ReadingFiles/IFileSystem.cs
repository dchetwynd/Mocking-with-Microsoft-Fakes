using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFiles
{
    public interface IFileSystem
    {
        string ReadAllText(string fileName);
    }
}
