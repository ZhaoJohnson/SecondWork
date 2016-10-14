using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowModel;

namespace ShowService
{
    public class WestShow:BasicShow<WestFactionModel>
    {
        public override void Bark()
        {
            
        }

        public override void HumanSound()
        {
            throw new NotImplementedException();
        }

        public override void Wind()
        {
            throw new NotImplementedException();
        }
    }
}
