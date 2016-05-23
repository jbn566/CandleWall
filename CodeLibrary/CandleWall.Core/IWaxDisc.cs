using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall
{
    public interface IWaxDisc : ICandleWallObject, Identity.IPlayerable<string>
    {
        JB2.Common.JB2Color Color { get; set; }
        DateTime CreationDate { get; set; }
        string OrginalCandle { get; set; }
    }
}
