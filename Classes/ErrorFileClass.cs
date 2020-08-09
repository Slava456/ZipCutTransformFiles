namespace ZipCutTransformFiles.Classes
{
    public class ErrorFileClass
    {
        string _fileName;
        public ErrorFileClass(string filename)
        {
            _fileName = filename;
        }
        public string GiveYourName() => _fileName;
    }
}
