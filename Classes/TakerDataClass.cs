using System;
using System.IO;

namespace ZipCutTransformFiles.Classes
{
    public class TakerAndBuilderDataClass
    {
        private string _directoryIn;
        private string _directoryOut;
        private int _countFileVal;
        public TakerAndBuilderDataClass() { }
        
        public void TakeData(ushort pixWidth, ushort pixHeigth, CollectionsClassForWF ccfwf)
        {
            TakeDataFromAllDirs(_directoryIn, _directoryOut, pixWidth, pixHeigth, ccfwf);
        }
        public int GetGiveCountFileVal() => _countFileVal;
        public void SetDirectoryIn(string directory) => _directoryIn = directory;
        public void SetDirectoryOut(string directory) => _directoryOut = directory;
        public bool isDirsNotNullOrEmpty() => !string.IsNullOrEmpty(_directoryIn) && !string.IsNullOrEmpty(_directoryOut);
        public bool isDirsOther() => _directoryIn != _directoryOut;
        public void ClearInfoAboutDirs()
        {
            _directoryIn = string.Empty;
            _directoryOut = string.Empty;
            _countFileVal = 0;
        }
        private void TakeDataFromAllDirs(string directory, string directoryOut, ushort pixWidth, ushort pixHeigth, CollectionsClassForWF ccfwf)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            DirectoryInfo[] dirs = dir.GetDirectories();
            ccfwf.EnterDirectoriesOut(directoryOut);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                string temppathFile = Path.Combine(directoryOut, file.Name);
                ccfwf.PutIntoCollection(file, directory, directoryOut, temppathFile, pixWidth, pixHeigth);
                _countFileVal++;
            }
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(directoryOut, subdir.Name);
                TakeDataFromAllDirs(subdir.FullName, temppath, pixWidth, pixHeigth, ccfwf);
            }
        }
    }
}
