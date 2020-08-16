using System.Windows.Forms;
using System.IO;
using System;

namespace ZipCutTransformFiles.Classes
{
    public class CollectionsClassForWF
    {
        private CollectionsClass ccorign;
        public CollectionsClassForWF(CollectionsClass cc)
        {
            ccorign = cc; 
        }
        public void TransformAndSaveFiles(ProgressBar pb, Label lbl)
        {
            for (int i = 0; i < ccorign.bfclst.Count; i++)
            {
                ccorign.bfclst[i].TransformAndSaveBF();
                lbl.Text = "Выполняются преобразования файла: " + ccorign.bfclst[i].GiveYourName();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                pb.Value++;
            }
            for (int i = 0; i < ccorign.pclst.Count; i++)
            {
                ccorign.pclst[i].TransformAndSavePic();
                lbl.Text = "Выполняются преобразования файла: " + ccorign.pclst[i].GiveYourName();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                pb.Value++;
            }
            for (int i = 0; i < ccorign.txtlst.Count; i++)
            {
                ccorign.txtlst[i].TransformAndSaveTXT();
                lbl.Text = "Выполняются преобразования файла: " + ccorign.txtlst[i].GiveYourName();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                pb.Value++;
            }
            for (int i = 0; i < ccorign.zfclst.Count; i++)
            {
                ccorign.zfclst[i].SaveZipFile();
                lbl.Text = "Выполняются преобразования файла: " + ccorign.zfclst[i].GiveYourName();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                pb.Value++;
            }
        }
        public string GiveStringWithErrorFiles() => ccorign.GiveStringWithErrorFiles();
        public void EnterDirectoriesOut(string directory) => ccorign.EnterDirectoriesOut(directory);
        public void CreateDirsOut() => ccorign.CreateDirsOut();
        public void PutIntoCollection(FileInfo file, string directory, string directoryOut, string temppathFile, ushort pixWidth, ushort pixHeigth)
        {
            ccorign.PutIntoCollection(file, directory, directoryOut, temppathFile, pixWidth, pixHeigth);
        }
        public void ClearAllCollectoins() => ccorign.ClearAllCollections();
    }
}
