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
        public virtual string Resident { get; set; }
        /// <summary>
        /// 桌
        /// </summary>
        public virtual string Table { get; set; }
        /// <summary>
        /// 椅
        /// </summary>
        public virtual string Chair { get; set; }
        /// <summary>
        /// 扇
        /// </summary>
        public virtual string Fan { get; set; }
        /// <summary>
        /// 尺
        /// </summary>
        public virtual string Ruler { get; set; }
    }
}
