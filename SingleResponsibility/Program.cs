using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {

            var srcfile = "c:\\dev\\test\\src.xml";
            var dstfile = "c:\\dev\\test\\dest.json";
            var formatconverter = new formatconverter();
            if (!formatconverter.ConvertFormat(srcfile, dstfile))
            {
                Console.WriteLine("conversion failed.");
                Console.ReadKey();
            }
        }
    }
}
