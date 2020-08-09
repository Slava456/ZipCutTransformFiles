using System.Windows.Forms;
using ZipCutTransformFiles.Forms;

namespace ZipCutTransformFiles.Classes
{
    public class FormsClass
    {
        public MainForm mf;
        public FormsClass() { }
        public Form InitMainForm() => mf = new MainForm();
    }
}
