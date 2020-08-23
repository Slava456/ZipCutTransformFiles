namespace ZipCutTransformFiles.Classes
{
    public class ErrorFileClass : IContracts
    {
        string _fileName;
        public ErrorFileClass(string filename)
        {
            _fileName = filename;
        }

        public string GiveYourName() => _fileName;
        public void TransformAndSave() { }
        
    }
}
