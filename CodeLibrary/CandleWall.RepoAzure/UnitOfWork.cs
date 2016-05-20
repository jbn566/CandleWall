using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall.Data.Azure
{
    public class UnitOfWork : JB2.CandleWall.IUnitofWork
    {
        #region Fields
        protected JB2.Common.Data.StorageAccount _storageAccount;
        protected Dictionary<string, object> _repos;
        protected const string _tableName = "candlewall";
        #endregion Fields

        #region Constructors
        public UnitOfWork(JB2.Common.Data.StorageAccount storageAccount)
        {
            _storageAccount = storageAccount;
            _repos = new Dictionary<string, object>();
        }


        #endregion Constructors

        #region IDisposal
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                //if (disposing)
                //{
                //    _repos.Di
                //}
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposal


        public ICandleRepository CandleRepository
        {
            get
            {
                return (CandleRepository)GetRepository("candle");
            }
        }

        public IPlayerRepository PlayerRepository
        {
            get
            {
                return (PlayerRepository)GetRepository("player");
            }
        }

        private object GetRepository(string repoKey)
        {
            var tablename = _tableName;

            //#if DEBUG
            //            tablename = _tableName + "00dev";
            //#endif
            if (!_repos.ContainsKey(repoKey))
            {
                switch (repoKey)
                {
                   
                    case "player":
                        _repos.Add("player", new PlayerRepository(_storageAccount.GetTable(tablename), _storageAccount.GetBlog(tablename)));
                        break;
                    case "candle":
                        _repos.Add("candle", new CandleRepository(_storageAccount.GetTable(tablename), _storageAccount.GetBlog(tablename)));
                        break;

                }
            }

            return _repos[repoKey];

        }

    }
}
