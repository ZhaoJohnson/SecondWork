using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public class NorthFactionModel : BasicModel
    {
        public override string Resident { get; set; }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
        public NorthFactionModel()
        {
            Chair = "北派折叠椅";
            Fan = "北派大师使用过的电风扇";
            Resident = "北派大师——“莱昂纳多·迪卡普里奥”";
            Ruler = "小如牙签的木尺";
            Table = "北方杉木大方桌";
        }
    }
}
