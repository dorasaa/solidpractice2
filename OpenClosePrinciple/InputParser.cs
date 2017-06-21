using Newtonsoft.Json;
using System.Xml.Linq;

namespace OpenClosePrinciple
{
    internal class InputParser: IInputParser
    {
        public InputParser() { }

        public Voucher ParseInput(string input) {

            var xdoc = XDocument.Parse(input);

            var doc = new Voucher
            {

                Iso = xdoc.Root.Element("Iso").Value,
                RefundChoice = xdoc.Root.Element("RefundChoice").Value,
                VoucherNumber = xdoc.Root.Element("VoucherNumber").Value,
                VoucherPart = xdoc.Root.Element("VoucherPart").Value
            };

            return doc;
          

        }
    }

     
}