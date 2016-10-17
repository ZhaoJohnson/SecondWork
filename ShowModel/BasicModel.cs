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
        /// <summary>
        /// 人
        /// </summary>
        public abstract string Resident { get; set; }
        /// <summary>
        /// 桌
        /// </summary>
        public abstract string Table { get; set; }
        /// <summary>
        /// 椅
        /// </summary>
        public abstract string Chair { get; set; }
        /// <summary>
        /// 扇
        /// </summary>
        public abstract string Fan { get; set; }
        /// <summary>
        /// 尺
        /// </summary>
        public abstract string Ruler { get; set; }
    }
}
