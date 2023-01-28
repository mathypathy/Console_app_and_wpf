using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WPF.Services
{
    internal class DocumentManagement
    {
        public string DocPath { get; set; } = null!;
        public void SaveDoc(string content)
        {
            using var sw = new StreamWriter(DocPath);
            sw.WriteLine(content);
        }
        public string ReadDoc()
        {
            try
            {
                using var sr = new StreamReader(DocPath);
                return sr.ReadToEnd();
            }
            catch
            {
                return null!;
            }
        }
    }
}
