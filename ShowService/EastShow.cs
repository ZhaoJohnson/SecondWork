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
    public class EastShow<Tmodel> : BasicShow<Tmodel>
        where Tmodel : BasicModel, new()
    {
        public override event Action ShowFire;
        Tmodel model = new Tmodel();
        public override void Bark()
        {
            MyLog.OutputAndSaveTxt($"{model.Resident}使用{model.Ruler}打了小狗狗，狗狗被打的");
        }

        public override void Fee()
        {
            MyLog.OutputAndSaveTxt("收费50元");
        }

        public override void HumanSound()
        {
            var Eastman = "不错我就是，" + model.Resident;
            MyLog.OutputAndSaveTxt(Eastman);
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 200)
                MyLog.OutputAndSaveTxt($"东派表演的掌声轰鸣，热情值上涨{temperature}" );
            if (temperature >= 800)
            {
                MyLog.OutputAndSaveTxt("现在温度{temperature}太高了，火太大了！！！" );
                ShowFire.Invoke();
            }

        }

        public override void Wind()
        {
            MyLog.OutputAndSaveTxt("大风吹起来了");
        }

    }
}
