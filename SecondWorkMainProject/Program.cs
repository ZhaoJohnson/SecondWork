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

                ThreadStart Eaststarter =
                  () => MyLog.OutputAndSaveTxt("~~~~~~~~~~~~~~~~~~随机的线程会在哪里出现呢~~~~~~~~~~~~~~~~~~~");
                new Thread(Eaststarter).Start();
                ShowBusiness<EastShow<EastFactionModel>, EastFactionModel>.StarShow(2200);//xml传入
                ShowBusiness<NorthShow<NorthFactionModel>, NorthFactionModel>.StarShow(2200);
                ShowBusiness<SouthShow<SouthFactionModel>, SouthFactionModel>.StarShow(2020);
                ShowBusiness<WestShow<WestFactionModel>, WestFactionModel>.StarShow(2200, WestFireAction());
                MyLog.OutputAndSaveTxt("");
                MyLog.OutputAndSaveTxt("<<<<<<<<<<<<<<<<<<<<<<<<<<表演结束>>>>>>>>>>>>>>>>>>>>>>>>>");

                
                MyLog.SaveEnd();
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                MyLog.SaveEx(ex.Message);
            }

        }
           
        
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
