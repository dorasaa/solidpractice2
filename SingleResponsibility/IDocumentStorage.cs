using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    interface IDocumentStorage
    {
        string GetData(string srcfile);
         void SaveData(string dstfile, string serializedVoucherObject);
         
    }
}
