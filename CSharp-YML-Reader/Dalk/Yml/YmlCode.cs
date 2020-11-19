﻿using System;
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
            string res = "";
            string[] con = code;
            foreach (string s in con)
            {
                if (s.StartsWith(name + ": "))
                {
                    res = s.Remove(0, name.Length + 2);
                }
            }
            return res;
        }
        public bool GetBool(string name)
        {
            string res = "false";
            string[] con = code;
            foreach (string s in con)
            {
                if (s.StartsWith(name + ": "))
                {
                    res = s.Remove(0, name.Length + 2);
                }
            }
            return Convert.ToBoolean(res);
        }
        public int GetInt(string name)
        {
            string res = "0";
            string[] con = code;
            foreach (string s in con)
            {
                if (s.StartsWith(name + ": "))
                {
                    res = s.Remove(0, name.Length + 2);
                }
            }
            return Convert.ToInt32(res);
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
