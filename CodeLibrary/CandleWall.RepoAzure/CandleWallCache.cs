using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall.Data.Azure
{
    public class CandleWallCache<TEntity> : JB2.Common.ExpirableDictionary<string, TEntity>
    {
    }

   
}
