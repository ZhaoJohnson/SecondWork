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
                IBasicShow show1 = new EastShow<EastFactionModel>();
                show1.Working();
                show1.ShowFire += () => Console.WriteLine("张三说：大家快来看表演啊！！！！");
                IPay EastPay= new EastShow<EastFactionModel>();
                EastPay.Fee();
                IBasicShow show2 = CreateFactory(EnumModel.Faction.EastFaction);
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

        
    }
}
