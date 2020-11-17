using System;
using System.IO;

namespace Dalk.Yml
{
    public class YmlCode
    {
        public YmlCode()
        {

        }
        private string[] code;
        public YmlCode(YmlFile file)
        {
            Load(file);
        }
        public YmlCode(string document)
        {
            Load(document);
        }
        public string GetString(string name)
        {
            string s = "";

            return s;
        }
        public void Load(YmlFile file)
        {
            Document = File.ReadAllText(file.FileName);
            code = Document.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        public void Load(string document)
        {
            Document = document;
            code = Document.Split(new char[] { '\n' },StringSplitOptions.RemoveEmptyEntries);
        }
        public string Document
        {
            get;
            internal set;
        }
    }
}
