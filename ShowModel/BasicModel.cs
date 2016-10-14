using IShowModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowModel
{
    public abstract class BasicModel:IBasicModel
    {
        public abstract string Resident { get; set; }
        public abstract string Table { get; set; }
        public abstract string Chair { get; set; }
        public abstract string Fan { get; set; }
        public abstract string Ruler { get; set; }
    }
}
