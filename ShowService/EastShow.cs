using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowModel;
using IShowModel;

namespace ShowService
{
    public class EastShow<Tmodel> : BasicShow<Tmodel>, IPay
        where Tmodel : BasicModel, new()
    {
        public override event Action ShowFire;
        Tmodel model = new Tmodel();
        public override void Bark()
        {
            Console.WriteLine($"{model.Resident}使用{model.Ruler}打了小狗狗，狗狗被打的");
        }

        public override void Fee()
        {
            Console.WriteLine("收费50元");
        }

        public override void HumanSound()
        {
            var Eastman = "不错我就是，" + model.Resident;
            Console.WriteLine(Eastman);
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 200)
                Console.WriteLine("东派表演的掌声轰鸣，热情值上涨{0}", temperature);
            if (temperature >= 800)
            {
                Console.WriteLine("现在温度{0}太高了，火太大了！！！", temperature);
                ShowFire.Invoke();
            }

        }

        public override void Wind()
        {
            Console.WriteLine("大风吹起来了");
        }

    }
}
