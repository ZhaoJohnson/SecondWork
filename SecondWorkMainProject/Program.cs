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
            string TheBasePath = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                //此处Console.SetOut是不是会导致，不会再将输出显示在控制台上呢？想不出什么好的将输出全部记录的简单方法。。。
                //ThreadStart starter = () => Console.SetOut(sw);
                //new Thread(starter).Start();
                ThreadStart Eaststarter =
                  () => MyLog.OutputAndSaveTxt("~~~~~~~~~~~~~~~~~~随机的线程会在哪里出现呢~~~~~~~~~~~~~~~~~~~");
                new Thread(Eaststarter).Start();
                ShowBusiness<EastShow<EastFactionModel>, EastFactionModel>.StarShow(2200, EastFireAction());
                ShowBusiness<NorthShow<NorthFactionModel>, NorthFactionModel>.StarShow(2200, NorthFireAction());
                ShowBusiness<SouthShow<SouthFactionModel>, SouthFactionModel>.StarShow(2020, SouthFireAction());
                ShowBusiness<WestShow<WestFactionModel>, WestFactionModel>.StarShow(2200, WestFireAction());
                MyLog.OutputAndSaveTxt("");
                MyLog.OutputAndSaveTxt("<<<<<<<<<<<<<<<<<<<<<<<<<<表演结束>>>>>>>>>>>>>>>>>>>>>>>>>");

                //sw.Flush();
                //sw.Close();
                //sw.Dispose();
                MyLog.SaveEnd();
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                MyLog.SaveEx(ex.Message);
            }

        }
           
        static List<Action> EastFireAction()
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
        static List<Action> NorthFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => MyLog.OutputAndSaveTxt("既而儿醒，大啼。夫亦醒。");
            Action a2 = () => MyLog.OutputAndSaveTxt("妇抚儿乳，儿含乳啼，妇拍而呜之。");
            result.Add(a1);
            result.Add(a2);
            
            return result;
        }
        static List<Action> SouthFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => MyLog.OutputAndSaveTxt("当是时，妇手拍儿声，口中呜声，儿含乳啼声，大儿初醒声，夫叱大儿声，一时齐发，众妙毕备。");
            Action a2 = () => MyLog.OutputAndSaveTxt("满坐宾客无不伸颈，侧目，微笑，默叹，以为妙绝。");
            result.Add(a1);
            result.Add(a2);
            return result;
        }
        static List<Action> WestFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => MyLog.OutputAndSaveTxt("未几，夫齁声起，妇拍儿亦渐拍渐止。");
            Action a2 = () => MyLog.OutputAndSaveTxt("微闻有鼠作作索索，盆器倾侧，妇梦中咳嗽。");
            result.Add(a1);
            return result;
        }
    }
}
