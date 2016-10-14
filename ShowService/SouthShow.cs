using ShowModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowService
{
    public class SouthShow<Tmodel> : BasicShow<Tmodel>
        where Tmodel : BasicModel, new()
    {
        public override void Bark()
        {
            throw new NotImplementedException();
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
