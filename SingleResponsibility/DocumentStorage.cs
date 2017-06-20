using System.IO;

namespace SingleResponsibility
{
    public class DocumentStorage 
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