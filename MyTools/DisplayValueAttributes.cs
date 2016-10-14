using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class DisplayValueAttributes:Attribute
    {
        public string Value { get; private set; }

        public DisplayValueAttributes(string value)
        {
            this.Value = value;
        }
    }
}
