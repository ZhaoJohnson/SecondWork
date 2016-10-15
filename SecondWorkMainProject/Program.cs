using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShowModel;
using ShowModel;
using ShowService;

namespace SecondWorkMainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //List<IBasicShow> ShowList = new List<IBasicShow>();
                IBasicShow show1 = new EastShow<EastFactionModel>();
                //show1.Working();
                //show1.ShowFire += () => Console.WriteLine("张三说：大家快来看表演啊！！！！");
                //IPay EastPay= new EastShow<EastFactionModel>();
                //EastPay.Fee();
                //IBasicShow show2 = CreateFactory(EnumModel.Faction.EastFaction);
                //ShowList.Add(show1);
                //ShowList.Add(show2);
                ShowBusiness<EastShow<EastFactionModel>, EastFactionModel>.StarShow((p)=>
                {
                    p.ShowFire += () => Console.WriteLine("123");
                    p.SetTemperature(555);
                    return () => Console.WriteLine("表演结束");
                });
                //ShowBusiness<EastShow<EastFactionModel>, EastFactionModel>.AddWorking(() => Console.WriteLine("哈哈哈"));
                //ShowBusiness<NorthShow<NorthFactionModel>, NorthFactionModel>.StarShow();
                //ShowBusiness<SouthShow<SouthFactionModel>, SouthFactionModel>.StarShow();
                //ShowBusiness<WestShow<WestFactionModel>, WestFactionModel>.StarShow();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        static IBasicShow CreateFactory(EnumModel.Faction enumstring)
        {
            switch (enumstring)
            {
                case EnumModel.Faction.EastFaction:
                    return new EastShow<EastFactionModel>();
                case EnumModel.Faction.NorthFaction:
                    return new NorthShow<NorthFactionModel>();
                case EnumModel.Faction.SouthFaction:
                    return new SouthShow<SouthFactionModel>();
                case EnumModel.Faction.WestFaction:
                    return new WestShow<WestFactionModel>();
            }
            throw  new Exception("请检查参数是否配置正确");
        }

        static IPay CostMoney(EnumModel.Faction theFaction)
        {
            switch (theFaction)
            {
                case EnumModel.Faction.EastFaction:
                    return new EastShow<EastFactionModel>();
                case EnumModel.Faction.NorthFaction:
                    return new NorthShow<NorthFactionModel>();
                case EnumModel.Faction.SouthFaction:
                    return new EastShow<EastFactionModel>();
                case EnumModel.Faction.WestFaction:
                    return new EastShow<EastFactionModel>();
                default:
                    break;
            }

        }
    }
}
