

namespace ConsoleApp.Services
{
    internal class DocumentManagement
    {
        public string DocPath { get; set; } = null!;

        public void SavedDocuments(string content, string DocPath)
        {

            using var sw = new StreamWriter(DocPath);
            sw.WriteLine(content);
        }
        public string ReadDocuments()
        {
            try
            {
                using var sr = new StreamReader(DocPath);
                return sr.ReadToEnd();
            }
            catch { return null!; }

        }
    }
}
