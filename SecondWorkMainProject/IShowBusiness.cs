using IShowModel;
using ShowService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWorkMainProject
{
    public interface IShowBusiness<TService, TModel>:IDisposable
        where TService : IBasicShow, new()
        where TModel : IBasicModel, new()
    {
    }
}
