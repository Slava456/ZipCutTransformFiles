using System;
using System.Collections.Generic;
using System.IO;

namespace ZipCutTransformFiles.Classes
{
    public class CollectionsClass
    {
        public List<PicturClass> pclst = new List<PicturClass>();
        public List<TxtClass> txtlst = new List<TxtClass>();
        public List<BinaryFileClass> bfclst = new List<BinaryFileClass>();
        public List<ZipFileClass> zfclst = new List<ZipFileClass>();
        public List<ErrorFileClass> efclst = new List<ErrorFileClass>();
        public List<DirectoryOutClass> dclst = new List<DirectoryOutClass>();
        public CollectionsClass() { }

        public void EnterDirectoriesOut(string directory)
        {
            DirectoryOutClass dc = new DirectoryOutClass(directory);
            dclst.Add(dc);
        }
        public void CreateDirsOut()
        {
            for (int i = 0; i < dclst.Count; i++)
            {
                dclst[i].CreateDirectory();
            }
        }
        public void PutIntoCollection(FileInfo file, string directory, string directoryOut, string temppathFile, ushort pixWidth, ushort pixHeigth)
        {
            if (isPic(file.Name.ToUpper()))
            {
                PicturClass pc = new PicturClass(file.Name, file.FullName, temppathFile, pixWidth, pixHeigth);
                pclst.Add(pc);
            }
            else if (isTXT(file.Name.ToUpper()))
            {
                TxtClass tc = new TxtClass(file.Name, file.FullName, temppathFile, directory);
                txtlst.Add(tc);
            }
            else if (isBF(file.Name.ToUpper()))
            {
                BinaryFileClass bfc = new BinaryFileClass(file.Name, file.FullName, temppathFile, directory);
                bfclst.Add(bfc);
            }
            else if (isZip(file.Name.ToUpper()))
            {
                ZipFileClass zfc = new ZipFileClass(file.Name, file.FullName, temppathFile);
                zfclst.Add(zfc);
            }
            else
            {
                ErrorFileClass efc = new ErrorFileClass(file.Name);
                efclst.Add(efc);
            }
        }
        public void ClearAllCollections()
        {
            bfclst.Clear();
            pclst.Clear();
            txtlst.Clear();
            zfclst.Clear();
            efclst.Clear();
            dclst.Clear();
        }

        public string GiveStringWithErrorFiles()
        {
            string str = string.Empty;
            if (efclst.Count != 0)
            {
                for (int i = 0; i < efclst.Count; i++)
                {
                    str += efclst[i].GiveYourName();
                    if (i + 1 != efclst.Count)
                    {
                        str += ", ";
                    }
                }
            }
            return str;
        }
        private bool isPic(string file)
        {
            if (file.Contains(".JPG")
                || file.Contains(".JPEG")
                || file.Contains(".PNG"))
            {
                return true;
            }
            return false;
        }
        private bool isTXT(string file)
        {
            if (file.Contains(".DOC")
                || file.Contains(".DOCX")
                || file.Contains(".PDF")
                || file.Contains(".TXT"))
            {
                return true;
            }
            return false;
        }
        private bool isZip(string file)
        {
            if (file.Contains(".RAR")
                || file.Contains(".ZIP"))
            {
                return true;
            }
            return false;
        }
        private bool isBF(string file)
        {
            if (file.Contains(".AVI")
                || file.Contains(".MPEG")
                || file.Contains(".MP4")
                || file.Contains(".MP3"))
            {
                return true;
            }
            return false;
        }
    }
}
