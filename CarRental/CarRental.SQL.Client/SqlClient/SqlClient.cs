using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CarRental.SQL.Client
{
    public abstract class SqlClient<TEntity> : IClient<TEntity>
    {
        protected readonly SqlConnection Connection = new SqlConnection("Server=tcp:car-rental.database.windows.net,1433;Initial Catalog=CarRental;Persist Security Info=False;User ID=carrental;Password=Ktu12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public abstract bool Create(TEntity entity);
        public abstract IList<TEntity> Read();
        public abstract bool Update(TEntity entity);
    }
}
