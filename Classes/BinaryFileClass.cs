using System;
using System.IO;
using System.IO.Compression;

namespace ZipCutTransformFiles.Classes
{
    public class BinaryFileClass
    {
        private string _fileName;
        private string _fileFullName;
        private string _temppathFile;
        private string _directory;
        public BinaryFileClass(string fileName, string fileFullName,string temppathFile,string directory)
        {
            _fileName = fileName;
            _fileFullName = fileFullName;
            _temppathFile = temppathFile;
            _directory = directory;
        }
        public void TransformAndSaveBF()
        {
            if (!File.Exists(_temppathFile + ".zip"))
            {
                using (ZipArchive zip = ZipFile.Open(_temppathFile + ".zip", ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(_fileFullName, _fileName);
                }
            }
        }
        public string GiveYourName() => _fileName;
    }
}
