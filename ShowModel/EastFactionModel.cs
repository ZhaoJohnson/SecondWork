using MyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public class EastFactionModel : BasicModel
    {
        [DisplayValueAttributes("东派")]
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
