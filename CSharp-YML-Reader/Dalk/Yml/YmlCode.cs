using System.IO;

namespace Dalk.Yml
{
    public class YmlCode
    {
        public YmlCode()
        {

        }
        public YmlCode(YmlFile file)
        {
            Load(file);
        }
        public YmlCode(string document)
        {
            Load(document);
        }
        public void Load(YmlFile file)
        {
            Document = File.ReadAllText(file.FileName);
        }
        public void Load(string document)
        {
            Document = document;
        }
        public string Document
        {
            get;
            internal set;
        }
    }
}
