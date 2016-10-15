using IShowModel;
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
        private static List<Action> ListAct { get; set; }
        public static void StarShow(int Temperature, List<Action> act=null)
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
            baseService.SetTemperature(Temperature);
            
        }

        #region Private Function
        private static void showPropertyName( IBasicModel model)
        {
            Console.WriteLine("******************{0}的属性及值******************", model.GetType().Name);
            foreach (PropertyInfo itemInfo in model.GetType().GetProperties())
            {
                Console.WriteLine(itemInfo.Name+":"+ itemInfo.GetValue(model));
            }
            Console.WriteLine("******************下面开始表演了**************************");
        }
                        
        #endregion
    }
}
