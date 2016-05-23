using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall
{
    public interface ICandle : ICandleWallObject, JB2.Identity.IPlayerable<string>
    {
        CandleState State { get; set; }

        JB2.Common.IPerson<string> Owner { get; set; }

        JB2.Common.JB2Color Color { get; set; }

        IEnumerable<IWaxDisc> WaxDiscs { get; set; }

        DateTime CreationDate { get; set; }

        int GetBurnedWax();



    }
}
