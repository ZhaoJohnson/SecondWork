using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public class SouthFactionModel : BasicModel
    {
        public override string Resident { get; set; }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
        public SouthFactionModel()
        {
            Chair = "南派小板凳";
            Fan = "南派大师使用过的折扇";
            Resident = "南派大师——克里斯钦．格雷";
            Ruler = "软皮尺";
            Table = "北方楠木珐琅圆桌";
        }
    }
}
