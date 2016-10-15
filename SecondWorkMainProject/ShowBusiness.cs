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
        public static void StarShow(Func<TService,Action> service)
        {
            var PropertyModel = SetPropertyValue();
            showPropertyName(PropertyModel);
            var _ShowService = CreateService();
            
        }
        public static void AddWorking(Action act)
        {
            ListAct.Add(act);
        }


        #region Private Function
        private static void showPropertyName( IBasicModel model)
        {
            Console.WriteLine("******************{0}的属性及值******************", model.GetType().Name);
            foreach (PropertyInfo itemInfo in model.GetType().GetProperties())
            {
                Console.WriteLine(itemInfo.Name+":"+ itemInfo.GetValue(model));
            }
            Console.WriteLine("******************动态分割线**************************");
        }
        private static IBasicModel SetPropertyValue()
        {
            Type t = typeof(TModel);
            var TResult = (BasicModel)Activator.CreateInstance(t);
            switch (t.Name)
            {
                case "EastFactionModel":
                    TResult = (EastFactionModel)TResult;
                    TResult.Chair = "东派高背椅";
                    TResult.Fan = "东派大师使用过的鹅毛扇";
                    TResult.Resident = "东派泰斗——东方不败来了";
                    TResult.Ruler = "长约8丈的钢尺";
                    TResult.Table = "东方樟木花雕八仙桌";
                    break;
                case "NorthFactionModel":
                    TResult = (NorthFactionModel)TResult;
                    TResult.Chair = "北派折叠椅";
                    TResult.Fan = "北派大师使用过的电风扇";
                    TResult.Resident = "北派大师——“莱昂纳多·迪卡普里奥”";
                    TResult.Ruler = "小如牙签的木尺";
                    TResult.Table = "北方杉木大方桌";
                    break;
                case "SouthFactionModel":
                    TResult = (SouthFactionModel)TResult;
                    TResult.Chair = "南派小板凳";
                    TResult.Fan = "南派大师使用过的折扇";
                    TResult.Resident = "南派大师——克里斯钦．格雷";
                    TResult.Ruler = "软皮尺";
                    TResult.Table = "北方楠木珐琅圆桌";
                    break;
                case "WestFactionModel":
                    TResult = (WestFactionModel)TResult;
                    TResult.Chair = "西派大火炕";
                    TResult.Fan = "北派大师使用过的CPU风扇";
                    TResult.Resident = "北派大师——“唐玄奘”";
                    TResult.Ruler = "锋利如剑的铁尺";
                    TResult.Table = "西方小石桌";
                    break;
                default:
                    throw new Exception("无法创建对象！！");
                    
            }
            return TResult;
        }

        private static IBasicShow CreateService()
        {
            Type t = typeof(TService);
            var TResult = (BasicShow<TModel>)Activator.CreateInstance(t);
            return TResult;
        }


        private static TResult CallService<TGenericServices, TResult>(
          /*Input */ TGenericServices serviceInstance,
          /*Output*/Func<TGenericServices, TResult> callServiceFn )
          where TGenericServices : IShowBusiness<TService, TModel>
        {
            using (var service = serviceInstance)
            {
                //Return call Engine
                return callServiceFn(service);
            }
        }
        #endregion
    }
}
