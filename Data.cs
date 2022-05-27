using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Data
    {
        public static string Value { get; set; }
        
        public string GetValue()
        {
            return Value;
        }
        public void SerValue(string str)
        {
            Value = str;
        }
    }

}

