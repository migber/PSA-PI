using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CarRental.SQL.Client
{
    public abstract class SqlClient<TEntity> : IClient<TEntity>
    {
        protected readonly MySqlConnection Connection = new MySqlConnection("Server=sql11.freesqldatabase.com;User Id=sql11174816;Password=IaU27AFvtI;Database=sql11174816;");

        public abstract bool Create(TEntity entity);
        public abstract IList<TEntity> Read();
        public abstract bool Update(TEntity entity);
    }
}
