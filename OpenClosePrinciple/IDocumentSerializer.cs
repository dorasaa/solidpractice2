using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    interface IDocumentSerializer
    {
        string serialize(Voucher doc);
    }
}
