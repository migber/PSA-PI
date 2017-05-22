using System.Collections.Generic;

namespace CarRental.SQL.Client.MemoryClient
{
    public abstract class MemoryClient<TEntity> : IClient<TEntity>
    {
        public abstract bool Create(TEntity entity);
        public abstract IList<TEntity> Read();
        public abstract bool Update(TEntity entity);
    }
}
