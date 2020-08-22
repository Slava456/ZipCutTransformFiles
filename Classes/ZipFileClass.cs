using System;
using System.IO;

namespace ZipCutTransformFiles.Classes
{
    public class ZipFileClass : IContracts
    {
        private string _fileName;
        private string _fileFullName;
        private string _temppathFile;
        public ZipFileClass(string fileName, string fileFullName, string temppathFile)
        {
            _fileName = fileName;
            _fileFullName = fileFullName;
            _temppathFile = temppathFile;
        }
        public void TransformAndSave()
        {
            if (!File.Exists(_temppathFile))
                File.Copy(_fileFullName, _temppathFile);
        }
        public string GiveYourName() => _fileName;
    }
}
