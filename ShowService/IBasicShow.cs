using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShowModel;

namespace ShowService
{
    public interface IBasicShow:IDisposable
    {
        void Working();
        void SetTemperature( int temperature );
        event Action ShowFire;
    }
}
