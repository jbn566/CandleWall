using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.CandleWall.Data.Azure
{
    public  abstract class CandleWallAzureRepository<TEntity, TKey, TSearchFilter> : JB2.Common.Data.AzureRepositoryWithCache<TEntity, TKey, TSearchFilter,
                                                                                       CandleWallCache<TEntity>, string>
    {
        #region Fields
        protected bool _useCache;

        #endregion Fields

        public CandleWallAzureRepository() : this(true)
        {

        }

        public CandleWallAzureRepository(bool useCache) : base()
        {
            _useCache = useCache;
        }


        public override void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override TEntity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public override TEntity[] GetAll(bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public override TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public override TEntity GetById(TKey id, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public override void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override TEntity[] SearchFor()
        {
            throw new NotImplementedException();
        }

        public override TEntity[] SearchFor(bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public override TEntity[] SearchFor(TSearchFilter filter)
        {
            throw new NotImplementedException();
        }

        public override TEntity[] SearchFor(TSearchFilter filter, bool useCache = true)
        {
            throw new NotImplementedException();
        }
    }
}
