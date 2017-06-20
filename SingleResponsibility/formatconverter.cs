﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class formatconverter
    {
        readonly DocumentStorage _documentStorage;
         readonly InputParser _inputparser;
        readonly documentSerializer _documentSerializer;
        public formatconverter()
        {
           _documentStorage=  new DocumentStorage();
            _inputparser = new InputParser();
            _documentSerializer = new documentSerializer();

        }

        public bool ConvertFormat(string src, string dest)
        {
            //Read
             string input;
            try
            {
                //Reads xml string
                input = _documentStorage.GetData(src);
             
            //Serialize
            //Converts xml to voucher object
            var doc = _inputparser.ParseInput(input);

            //Serialize voucher object to json text
            var SerializedDoc = _documentSerializer.serialize(doc); 
            //save the output
             _documentStorage.SaveData(dest, SerializedDoc);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
