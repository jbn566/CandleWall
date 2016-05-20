using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall
{
    public interface ICandleRepository: JB2.Common.IRepositoryWithCache<ICandle,string,string>
    {
    }
}
