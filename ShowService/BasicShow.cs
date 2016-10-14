using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShowModel;
using ShowModel;

namespace ShowService
{
    public abstract class BasicShow<TModel>: IBasicShow,IPay where TModel : IBasicModel
    {
        /// <summary>
        /// 开场
        /// </summary>
        public void InitialShow()
        {
            Type type = typeof (TModel);
            Console.WriteLine("接下来我们由请：{0}来为大家表演",type.Name);
        }
        /// <summary>
        /// 狗狗叫
        /// </summary>
        public abstract void Bark();
        /// <summary>
        /// 人声
        /// </summary>
        public abstract void HumanSound();
        /// <summary>
        /// 风声
        /// </summary>
        public abstract void Wind();

        /// <summary>
        /// 开场白
        /// </summary>
        public virtual void Prologue()
        {
            Console.WriteLine("Welcome!");
        }
        /// <summary>
        /// 闭幕，结束语
        /// </summary>
        public virtual void ConcludingRemarks()
        {
            Console.WriteLine("See U Again!");
        }

        public void Fee()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
