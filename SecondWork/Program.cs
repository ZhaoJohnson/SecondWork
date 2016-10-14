using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WorkModel;
using WorkService;

namespace SecondWork
{
    class Program
    {
        static void Main(string[] args)
        {

            EastSect eastSect=new EastSect();
            NorthScet northScet=new NorthScet();
            SouthSect southSect=new SouthSect();
            WestSect westSect=new WestSect();
            
            BasicService.Print(eastSect);
            eastSect.InitialShow();
            eastSect.Prologue();
            eastSect.Bark();
            eastSect.HumanSound();
            eastSect.Wind();
            eastSect.ConcludingRemarks();
            eastSect.Fee();
            eastSect.Fire += eastSect.SetTemperature(1);
            eastSect.Fire += () =>
            {
                Console.WriteLine("do1");
                Console.WriteLine("do2");
                Console.WriteLine("do3");
                Console.WriteLine("do4");
                Console.WriteLine("do5");
            };

            eastSect.GetPropertyValue(p =>p.Resident);

            Console.ReadKey();
        }

        

    }
}
