using System;
using NUnit.Framework;
using ReadingFiles.Fakes;

namespace ReadingFiles.Tests
{
    [TestFixture]
    public class FileReaderTest
    {
        [Test]
        public void FileIsNotEmpty()
        {
            string fileName = "MyFile.txt";
            string fileContents = "Hello, World!";

            var fileSystemOne = new StubIFileSystem();
            fileSystemOne.ReadAllTextString = delegate(string file)
            {
                return fileContents;
            };

            var fileSystemTwo = new StubIFileSystem()
            {
                ReadAllTextString = (file) =>
                {
                    return fileContents;
                }
            };

            Assert.False(FileReader.IsFileEmpty(fileSystemOne, fileName));
            Assert.False(FileReader.IsFileEmpty(fileSystemTwo, fileName));
        }

        [Test]
        public void FileIsEmpty()
        {
            string fileName = "MyFile.txt";

            var fileSystem = new StubIFileSystem()
            {
                ReadAllTextString = (file) =>
                {
                    return string.Empty;
                }
            };

            Assert.True(FileReader.IsFileEmpty(fileSystem, fileName));
        }
    }
}
