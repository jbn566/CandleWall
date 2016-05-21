﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall
{
    public interface ICandle : ICandleWallObject
    {
        CandleState State { get; set; }

        JB2.Common.IPerson<string> Owner { get; set; }
    }
}
