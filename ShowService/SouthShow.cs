using IShowModel;
using ShowModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowService
{
    public class SouthShow<Tmodel> : BasicShow<Tmodel>, IPay
        where Tmodel : BasicModel, new()
    {
        Tmodel model = new Tmodel();
        public override event Action ShowFire;
        public override void Prologue()
        {
            Console.WriteLine("泪滴森，安嘚，贱特们");
        }
        public override void Bark()
        {
            Console.WriteLine("南派养都是小柴犬");
        }

        public override void Fee()
        {
            Console.WriteLine("南派门票要收500元");
        }

        public override void HumanSound()
        {
            Console.WriteLine("{0}，在一个转身后发出了“啦啦”的声音",model.Resident);
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 200)
                Console.WriteLine("东派表演的掌声轰鸣，热情值上涨{0}", temperature);
            if (temperature >= 800)
                ShowFire.Invoke();
        }

        public override void Wind()
        {
            Console.WriteLine($"{model.Fan}吹来了阵阵微风");
        }
    }
}
