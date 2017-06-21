using System.IO;

namespace OpenClosePrinciple
{
    public class DocumentStorage : IDocumentStorage
    {
        public string GetData(string srcfile)
        {
            string input;
            using (var stream = File.OpenRead(srcfile))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            return input;
        }

        public  void SaveData(string dstfile,string serializedVoucherObject)
        {
            using (var stream = File.Open(dstfile, FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(serializedVoucherObject);
                sw.Close();
            }
        }
    }
}