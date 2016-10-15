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
            StreamWriter sw = MyLog.setStream(TheBasePath);
            try
            {
                //此处Console.SetOut是不是会导致，不会再将输出显示在控制台上呢？
                //ThreadStart starter = () => Console.SetOut(sw);
                //new Thread(starter).Start();
                ThreadStart Eaststarter = () => Console.WriteLine("~~~~~~~~~~~~~~~~~~随机的线程会在哪里出现呢~~~~~~~~~~~~~~~~~~~");
                new Thread(Eaststarter).Start();
                ShowBusiness<EastShow<EastFactionModel>, EastFactionModel>.StarShow(1200, EastFireAction());
                ShowBusiness<NorthShow<NorthFactionModel>, NorthFactionModel>.StarShow(1300, NorthFireAction());
                ShowBusiness<SouthShow<SouthFactionModel>, SouthFactionModel>.StarShow(1400, SouthFireAction());
                ShowBusiness<WestShow<WestFactionModel>, WestFactionModel>.StarShow(1500, WestFireAction());
                Console.WriteLine("");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<表演结束>>>>>>>>>>>>>>>>>>>>>>>>>");

                sw.Flush();
                sw.Close();
                sw.Dispose();
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MyLog.SaveEx(ex.Message);
                throw ex;
            }

        }
                
        static List<Action> EastFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => Console.WriteLine("夫起大呼，妇亦起大呼。两儿齐哭。俄而百千人大呼，百千儿哭，百千犬吠。");
            result.Add(a1);
            return result;
        }
        static List<Action> NorthFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => Console.WriteLine("既而儿醒，大啼。夫亦醒。");
            Action a2 = () => Console.WriteLine("妇抚儿乳，儿含乳啼，妇拍而呜之。");
            result.Add(a1);
            result.Add(a2);
            return result;
        }
        static List<Action> SouthFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => Console.WriteLine("当是时，妇手拍儿声，口中呜声，儿含乳啼声，大儿初醒声，夫叱大儿声，一时齐发，众妙毕备。");
            Action a2 = () => Console.WriteLine("满坐宾客无不伸颈，侧目，微笑，默叹，以为妙绝。");
            result.Add(a1);
            result.Add(a2);
            return result;
        }
        static List<Action> WestFireAction()
        {
            List<Action> result = new List<Action>();
            Action a1 = () => Console.WriteLine("未几，夫齁声起，妇拍儿亦渐拍渐止。");
            Action a2 = () => Console.WriteLine("微闻有鼠作作索索，盆器倾侧，妇梦中咳嗽。");
            result.Add(a1);
            return result;
        }
    }
}
