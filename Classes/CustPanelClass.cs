using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZipCutTransformFiles.Classes
{
    public class CustPanelClass : Panel
    {
        private string[] _directory = new string[1];
        private Label _lblWithPanel;
        public CustPanelClass(Label lblWithPanel)
        {
            AllowDrop = true;
            Size = new Size(67, 37);
            BackColor = Color.White;
            _lblWithPanel = lblWithPanel;
        }
        public void Pnl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        public void Pnl_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_directory[0]))
                {
                    _directory = (string[])e.Data.GetData(DataFormats.FileDrop);
                    DirectoryInfo dir = new DirectoryInfo(_directory[0]);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    _lblWithPanel.Text = ClassWithStaticParam.DirComplet;
                }
                else
                {
                    _ = MessageBox.Show("Директория уже задана");
                }
            }
            catch (IOException)
            {
                _directory[0] = string.Empty;
                _ = MessageBox.Show("Директория некорректна, попробуйте ещё раз");
            }
        }
        public string GiveDirectory() => _directory[0];
        public void ClearDir() => _directory[0] = string.Empty;
    }
}
