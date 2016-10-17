using IShowModel;
using ShowModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace ShowService
{
    public class SouthShow<Tmodel> : BasicShow<Tmodel>
        where Tmodel : BasicModel, new()
    {
        Tmodel model = new Tmodel();
        public override event Action ShowFire;
        public override void Prologue()
        {
            MyLog.OutputAndSaveTxt("泪滴森，安嘚，贱特们");
        }
        public override void Bark()
        {
            MyLog.OutputAndSaveTxt("南派养都是小柴犬");
        }

        public override void Fee()
        {
            MyLog.OutputAndSaveTxt("南派门票要收500元");
        }

        public override void HumanSound()
        {
            MyLog.OutputAndSaveTxt($"{model.Resident}，在一个转身后发出了“啦啦”的声音");
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 300)
                MyLog.OutputAndSaveTxt($"南派表演的掌声轰鸣，热情值上涨{temperature}");
            if (temperature >= 1200)
                ShowFire.Invoke();
        }

        public override void Wind()
        {
            MyLog.OutputAndSaveTxt($"{model.Fan}吹来了阵阵微风");
        }
    }
}
