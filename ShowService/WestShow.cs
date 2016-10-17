using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowModel;
using IShowModel;
using MyTools;

namespace ShowService
{
    public class WestShow<Tmodel> : BasicShow<Tmodel>
        where Tmodel : BasicModel, new()
    {
        public override event Action ShowFire;
        Tmodel model = new Tmodel();
        public override void Bark()
        {
            MyLog.OutputAndSaveTxt($"西派养的藏獒咬断了{model.Ruler},并跳上了{model.Table},对着{model.Resident}大叫！");
        }

        public override void Fee()
        {
            MyLog.OutputAndSaveTxt("每人收取五匹丝绸");
        }

        public override void HumanSound()
        {
            MyLog.OutputAndSaveTxt($"{model.Resident}没有发出什么声音");
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 400)
                MyLog.OutputAndSaveTxt($"西派表演的掌声轰鸣，热情值上涨{temperature}");
            if (temperature >= 1600)
                ShowFire.Invoke();
        }

        public override void Wind()
        {
            MyLog.OutputAndSaveTxt($"{model.Fan}似乎没有什么风");
        }
        public override void ConcludingRemarks()
        {
            MyLog.OutputAndSaveTxt("阿弥托福");
        }
        public override void Prologue()
        {
            MyLog.OutputAndSaveTxt("还有谁！");
        }
    }
}
