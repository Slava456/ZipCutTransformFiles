using System.Windows.Forms;

namespace ZipCutTransformFiles.Classes
{
    public class CustTextBoxClass : TextBox
    {
        private ushort _value;

        public CustTextBoxClass()
        {
            Multiline = true;
            Dock = DockStyle.Fill;
            Text = string.Empty;
        }
        public bool isCorrectDigit()
        {
            if (string.IsNullOrEmpty(Text))
            {
                _value = 0;
                return true;
            }
            else
            {
                return ushort.TryParse(Text, out _value);
            }
        }
        public ushort GiveValFromCTB() => _value;
    }
}
