using System;
using System.IO;

namespace ZipCutTransformFiles.Classes
{
    public class DirectoryOutClass
    {
        string _directoryOut;
        public DirectoryOutClass(string directory)
        {
            _directoryOut = directory;
        }
        public void CreateDirectory()
        {
            if (!Directory.Exists(_directoryOut))
            {
                Directory.CreateDirectory(_directoryOut);
            }
        }
    }
}
