using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall.Data.Azure
{
    public class PlayerRepository : CandleWallAzureRepository<IPlayer,string,string>, JB2.CandleWall.IPlayerRepository
    {
        #region Constructor
        public PlayerRepository(string tableName, string blogName, JB2.Common.Data.StorageAccount account, bool useCache = true) : this(account.GetTable(tableName), account.GetBlog(blogName), useCache)
        {

        }

        public PlayerRepository(JB2.Common.Data.AzureTableRepository table, JB2.Common.Data.AzureBlobRepository blob, bool useCache = true) : base(useCache)
        {
            _table = table;
            _blob = blob;
        }
        #endregion Constructor
    }
}
