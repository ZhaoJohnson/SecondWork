using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShowModel;
using ShowModel;
using ShowService;
using System.IO;
using MyTools;
using System.Threading;

namespace SecondWorkMainProject
{
    class Program
    {
        static void Main( string[] args )
        {
            //设置基础目录
            try
            {
               
                ShowBusiness<EastShow<EastFactionModel>, EastFactionModel>.StarShow(2200);//xml传入事件
                ShowBusiness<NorthShow<NorthFactionModel>, NorthFactionModel>.StarShow(2200);//xml传入事件
                ShowBusiness<SouthShow<SouthFactionModel>, SouthFactionModel>.StarShow(2020);//xml传入事件
                ShowBusiness<WestShow<WestFactionModel>, WestFactionModel>.StarShow(2200, WestFireAction());//程序内部注册
                MyLog.OutputAndSaveTxt("");
                MyLog.OutputAndSaveTxt("<<<<<<<<<<<<<<<<<<<<<<<<<<表演结束>>>>>>>>>>>>>>>>>>>>>>>>>");
                
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                MyLog.SaveEx(ex.Message);
            }

        }
           
        /// <summary>
        /// 内部注册
        /// </summary>
        /// <returns></returns>
        static List<Action> WestFireAction()
        {
            return new List<Action>()
            {
                ()=>Console.WriteLine("夫起大呼,"),
                ()=>Console.WriteLine("妇亦起大呼。"),
                ()=>Console.WriteLine("两儿齐哭。"),
                ()=>Console.WriteLine("俄而百千人大呼，"),
                ()=>Console.WriteLine("百千儿哭，"),
                ()=>Console.WriteLine("百千犬吠。")
            };
        }
    }
}
