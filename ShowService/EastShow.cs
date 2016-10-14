using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowModel;
using IShowModel;

namespace ShowService
{
    public class EastShow<Tmodel>:BasicShow<Tmodel>, IPay
        where Tmodel : BasicModel ,new()
    {
        public override event Action ShowFire;

        public override void Bark()
        {
            Console.WriteLine("开始叫了");
        }

        public void Fee()
        {
            Console.WriteLine("收费50元");
        }

        public override void HumanSound()
        {
            new Exception("此处报错");
           Tmodel model=new Tmodel();
            model.Resident = "东方不败";
            var Eastman = "不错我就是，"+model.Resident;
            Console.WriteLine(Eastman);
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null) return;

            if (temperature==200)
                Console.WriteLine("东派表演的掌声轰鸣，热情值上涨{0}",temperature);
            if (temperature>=400)
                ShowFire.Invoke();
        }

        public override void Wind()
        {
            Console.WriteLine("大风吹起来了");
        }

    }
}
