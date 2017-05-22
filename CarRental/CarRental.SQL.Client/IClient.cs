using System.Collections.Generic;

namespace CarRental.SQL.Client
{
    public interface IClient<TEntity>
    {
        bool Create(TEntity entity);
        bool Update(TEntity entity);
        IList<TEntity> Read();
    }
}