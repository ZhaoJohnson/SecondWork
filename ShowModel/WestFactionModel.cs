using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public class WestFactionModel:BasicModel
    {
        public override string Resident { get; set; }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
        public WestFactionModel()
        {
            Chair = "西派大火炕";
            Fan = "北派大师使用过的CPU风扇";
            Resident = "北派大师——“唐玄奘”";
            Ruler = "锋利如剑的铁尺";
            Table = "西方小石桌";
        }
    }
}
