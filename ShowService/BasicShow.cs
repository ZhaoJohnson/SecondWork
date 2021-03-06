﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShowModel;
using ShowModel;
using System.Reflection;
using MyTools;

namespace ShowService
{
    /// <summary>
    /// 业务层负责实现具体业务
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class BasicShow<TModel> : IBasicShow, IPay
        where TModel : IBasicModel, new()
    {
        /// <summary>
        /// 开场
        /// </summary>
        public void InitialShow()
        {
            ///Update,通过反射+读取配置文件（Json/Xml）新建对象。
            TModel model = new TModel();
            ShowPropertyName(model);
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
            MyLog.OutputAndSaveTxt("Welcome!");
        }
        /// <summary>
        /// 闭幕，结束语
        /// </summary>
        public virtual void ConcludingRemarks()
        {
            MyLog.OutputAndSaveTxt("See U Again!");
        }
        public abstract event Action ShowFire;
        public abstract void SetTemperature(int temperature);
        /// <summary>
        /// 统一调用顺序,当然这样调用方法确实不合理 - -#
        /// </summary>
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
        
        /// <summary>
        /// 通过反射显示属性及值
        /// </summary>
        /// <param name="model"></param>
        private static void ShowPropertyName(TModel model)
        {
            var tResult = MyJsonHelper.Json2Object(model);
            MyLog.OutputAndSaveTxt($"******************{GetObjectName<TModel>()}的属性及值******************");
            foreach (PropertyInfo itemInfo in tResult.GetType().GetProperties())
            {
                MyLog.OutputAndSaveTxt(itemInfo.Name + ":" + itemInfo.GetValue(tResult));
            }
           
            MyLog.OutputAndSaveTxt("******************下面开始表演了**************************");
        }
        /// <summary>
        /// 收费
        /// </summary>
        public abstract void Fee();
        private static string GetObjectName<TModel>()
        {
            Type type = typeof (TModel);
            
            string PrimaryKey = string.Empty;
            foreach (var item in type.GetCustomAttributes(false))
            {
                if (item.GetType() == typeof(DisplayValueAttributes))
                {
                    DisplayValueAttributes propertyValue = item as DisplayValueAttributes;
                   return propertyValue.Value;
                }
            }
            if (string.IsNullOrEmpty(PrimaryKey)) return null;
            return PrimaryKey;
        }
    }
}
