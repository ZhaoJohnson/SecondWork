using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowModel;
using IShowModel;

namespace ShowService
{
    public class WestShow<Tmodel> : BasicShow<Tmodel>, IPay
        where Tmodel : BasicModel, new()
    {
        public override event Action ShowFire;
        Tmodel model = new Tmodel();
        public override void Bark()
        {
            Console.WriteLine($"西派养的藏獒咬断了{model.Ruler},并跳上了{model.Table},对着{model.Resident}大叫！");
        }

        public override void Fee()
        {
            Console.WriteLine("每人收取五匹丝绸");
        }

        public override void HumanSound()
        {
            Console.WriteLine($"{model.Resident}没有发出什么声音");
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 200)
                Console.WriteLine("东派表演的掌声轰鸣，热情值上涨{0}", temperature);
            if (temperature >= 400)
                ShowFire.Invoke();
        }

        public override void Wind()
        {
            Console.WriteLine($"{model.Fan}似乎没有什么风");
        }
        public override void ConcludingRemarks()
        {
            Console.WriteLine("阿弥托福");
        }
        public override void Prologue()
        {
            Console.WriteLine("还有谁！");
        }
    }
}
