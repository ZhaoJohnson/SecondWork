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
            BasicModel Show = new WestFactionModel();
            EastShow<EastFactionModel> show=new EastShow<EastFactionModel>();
            show.HumanSound();
            Console.ReadKey();
            IBasicShow show1=new EastShow<EastFactionModel>();
            
        }


        static IBasicModel CreateFactory(EnumModel.Faction enumstring)
        {
            switch (enumstring)
            {
                case EnumModel.Faction.EastFaction:
                    return new WestFactionModel();
                case EnumModel.Faction.NorthFaction:
                    return new WestFactionModel();
                case EnumModel.Faction.SouthFaction:
                    return new WestFactionModel();
                case EnumModel.Faction.WestFaction:
                    return new WestFactionModel();
            }
            throw  new Exception("请检查参数是否配置正确");
        }
    }
}
