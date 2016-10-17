﻿using IShowModel;
using SecondWorkMainProject;
using ShowModel;
using ShowService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondWorkMainProject
{
    public class ShowBusiness<TService,TModel> : IShowBusiness<TService,TModel>
        where TService:BasicShow<TModel>,new()
        where TModel:BasicModel,new()
    {
        
        public void Dispose()
        {
            
        }
        /// <summary>
        /// 应用层直接调用
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="act"></param>
        public static void StarShow(int temperature, List<Action> act=null)
        {
            TService baseService = new TService();
            if (act!=null)
            {
                foreach (Action item in act)
                {
                    baseService.ShowFire += item;
                }
            }
            baseService.Working();
            baseService.SetTemperature(temperature);
        }
        
    }
}
