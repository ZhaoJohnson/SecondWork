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
        public override event Action ShowFire;

        public override void Bark()
        {
            throw new NotImplementedException();
        }

        public void Fee()
        {
            throw new NotImplementedException();
        }

        public override void HumanSound()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
