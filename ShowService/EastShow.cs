using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowModel;

namespace ShowService
{
    public class EastShow<Tmodel>:BasicShow<Tmodel>
        where Tmodel : BasicModel ,new()
    {
        public override void Bark()
        {
            throw new NotImplementedException();
        }

        public override void HumanSound()
        {
           Tmodel model=new Tmodel();
            model.Resident = "东方不败";
            var Eastman = "不错我就是，"+model.Resident;
            Console.WriteLine(Eastman);
        }

        public override void Wind()
        {
            throw new NotImplementedException();
        }
    }
}
