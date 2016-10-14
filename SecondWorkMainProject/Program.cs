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
                BasicModel Show = new WestFactionModel();
                EastShow<EastFactionModel> show = new EastShow<EastFactionModel>();
                show.HumanSound();
                Console.ReadKey();
                IBasicShow show1 = new EastShow<EastFactionModel>();
                IBasicShow show2 = CreateFactory(EnumModel.Faction.EastFaction);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
           
            
        }


        static IBasicShow CreateFactory(EnumModel.Faction enumstring)
        {
            switch (enumstring)
            {
                case EnumModel.Faction.EastFaction:
                    return new EastShow<EastFactionModel>();
                case EnumModel.Faction.NorthFaction:
                    return new EastShow<EastFactionModel>();
                case EnumModel.Faction.SouthFaction:
                    return new EastShow<EastFactionModel>();
                case EnumModel.Faction.WestFaction:
                    return new EastShow<EastFactionModel>();
            }
            throw  new Exception("请检查参数是否配置正确");
        }
    }
}
