using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WithRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {

            var srcfile = "c:\\dev\\test\\src.xml";
            var dstfile = "c:\\dev\\test\\dest.json";

            string input;
            using (var stream = File.OpenRead(srcfile))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            var xdoc = XDocument.Parse(input);

            var doc = new Voucher
            {

                Iso = xdoc.Root.Element("Iso").Value,
                RefundChoice = xdoc.Root.Element("RefundChoice").Value,
                VoucherNumber = xdoc.Root.Element("VoucherNumber").Value,
                VoucherPart = xdoc.Root.Element("VoucherPart").Value
            };


            var serializedDoc = JsonConvert.SerializeObject(doc);
            using (var stream = File.Open(dstfile, FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(serializedDoc);
                sw.Close();
            }


        
    }
    }
}
