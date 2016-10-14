using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public class EastFactionModel : BasicModel
    {
        private string _resident;
        public override string Resident {
            get { return "东派首席弟子" + this._resident; }

            set { _resident = value;}
        }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
    }
}
