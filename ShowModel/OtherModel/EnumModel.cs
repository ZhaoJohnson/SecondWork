using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace ShowModel
{
    public class EnumModel
    {
      public enum Faction
      {
            [DisplayValueAttributes("东派")]
            EastFaction =1,
            [DisplayValueAttributes("北派")]
            NorthFaction =2,
            [DisplayValueAttributes("南派")]
            SouthFaction =3,
            [DisplayValueAttributes("西派")]
            WestFaction =4
      }
    }
}
