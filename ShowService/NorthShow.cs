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
    public class NorthShow<Tmodel> : BasicShow<Tmodel>
        where Tmodel : BasicModel, new()
    {
        public override event Action ShowFire;
        Tmodel model = new Tmodel();
        public override void Bark()
        {
            MyLog.OutputAndSaveTxt($"北派的小狗北{model.Ruler}打了，到处乱叫");
        }

        public override void Fee()
        {
            MyLog.OutputAndSaveTxt($"北派门票费用被德海社收走了！！！55555~");
        }

        public override void HumanSound()
        {
            MyLog.OutputAndSaveTxt($"{model.Resident}在{model.Table}被踢倒后，站了起来");
        }

        public override void SetTemperature( int temperature )
        {
            if (ShowFire == null)
                return;

            if (temperature == 500)
                MyLog.OutputAndSaveTxt($"北派派表演的掌声轰鸣，热情值上涨{temperature}");
            if (temperature >= 1000)
                ShowFire.Invoke();
        }

        public override void Wind()
        {
            MyLog.OutputAndSaveTxt($"{model.Fan}被{model.Resident}挥舞出了一阵大风");
        }

        public override void ConcludingRemarks()
        {
            MyLog.OutputAndSaveTxt($"我们要去德海社讨回工资！");
        }
    }
}
