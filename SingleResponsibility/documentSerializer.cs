using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class documentSerializer
    {
        public documentSerializer() { }
        public string serialize(Voucher doc) {
            return JsonConvert.SerializeObject(doc);
        }
    }
}
