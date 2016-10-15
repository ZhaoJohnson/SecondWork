using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public class EastFactionModel : BasicModel
    {
        public override string Resident { get; set; }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
        public EastFactionModel()
        {
            Chair = "东派高背椅";
            Fan = "东派大师使用过的鹅毛扇";
            Resident = "东派泰斗——东方不败来了";
            Ruler = "长约8丈的钢尺";
            Table = "东方樟木花雕八仙桌";
        }

    }
}
