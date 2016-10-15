using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShowModel;
using ShowModel;
using System.Reflection;

namespace ShowService
{
    public abstract class BasicShow<TModel> : IBasicShow , IPay
        where TModel : IBasicModel ,new()
    {
        /// <summary>
        /// 开场
        /// </summary>
        public void InitialShow()
        {
            TModel model = new TModel();
            showPropertyName(model);
            Console.WriteLine("接下来我们由请：{0}来为大家表演", GetvalueName());
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
        public abstract event Action ShowFire;
        public abstract void SetTemperature( int temperature );
       
        public virtual void Working()
        {
            InitialShow();
            Prologue();
            Bark();
            HumanSound();
            Wind();
            ConcludingRemarks();
            Fee();
        }
        public void Dispose()
        {
         
        }

        private string GetvalueName( )
        {
            switch (typeof(TModel).Name)
            {
                case "EastFactionModel":
                    return "东派";
                case "NorthFactionModel":
                    return "北派";
                case "SouthFactionModel":
                    return "南派";
                case "WestFactionModel":
                    return "西派";
                default:
                    return "动物园";
            }

        }
        private static void showPropertyName( TModel model)
        {
            Console.WriteLine("******************{0}的属性及值******************", typeof(TModel).Name);
            foreach (PropertyInfo itemInfo in model.GetType().GetProperties())
            {
                Console.WriteLine(itemInfo.Name + ":" + itemInfo.GetValue(model));
            }
            Console.WriteLine("******************动态分割线**************************");
        }

        public abstract void Fee();
        
    }
}
