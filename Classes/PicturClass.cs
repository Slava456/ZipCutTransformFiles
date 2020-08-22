using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ZipCutTransformFiles.Classes
{
    public class PicturClass : IContracts
    {
        private string _fileName;
        private string _fileFullname;
        private string _temppathFile;
        private Bitmap _bm;
        private Size _size;
        private ushort _pixWidth;
        private ushort _pixHeigth;

        public PicturClass(string fileName, string fileFullname, string temppathFile, ushort pixWidth, ushort pixHeigth)
        {
            _fileName = fileName;
            _fileFullname = fileFullname;
            _temppathFile = temppathFile;
            _pixWidth = pixWidth;
            _pixHeigth = pixHeigth;
            _bm = new Bitmap(fileFullname);
            _size = _bm.Size;
        }

        public void TransformAndSave()
        {
            if (!File.Exists(_temppathFile))
            {
                Size newsize = new Size();
                newsize.Height = SetVal(TypeSiz.Heigth);
                newsize.Width = SetVal(TypeSiz.Width);
                Bitmap newbitmap = new Bitmap(_bm, newsize);
                newbitmap.Save(_temppathFile, ImageFormat.Jpeg);
            }
        }
        public string GiveYourName() => _fileName;
        private int SetVal(TypeSiz type)
        {
            if (type == TypeSiz.Heigth)
            {
                if (_pixHeigth != 0)
                {
                    return _pixHeigth;
                }
                else
                {
                    return _size.Height;
                }
            }
            else if (type == TypeSiz.Width)
            {
                if (_pixWidth != 0)
                {
                    return _pixWidth;
                }
                else
                {
                    return _size.Width;
                }
            }
            else
            {
                return 0;
            }
        }
        private enum TypeSiz { Heigth = 0, Width = 1 }
    }
}
