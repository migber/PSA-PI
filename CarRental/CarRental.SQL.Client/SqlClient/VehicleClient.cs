using System.Collections.Generic;
using CarRental.Models.Vehicle;

namespace CarRental.SQL.Client.SqlClient
{
    public class VehicleClient : SqlClient<Vehicle>
    {
        public override bool Create(Vehicle vehicle)
        {
            var sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO Vehicle (Color, Wear, Brand, Model, Type, Year, StatusId, SizeId, Cost) VALUES";

            sqlCommand.CommandText += $"('{vehicle.Color}', '{vehicle.Wear}', '{vehicle.Brand}', '{vehicle.Model}', '{vehicle.Type}', " +
                                      $"'{vehicle.Year}', '{(int)vehicle.Status}', '{(int)vehicle.Size}', '{vehicle.Cost}');";
            Connection.Open();

            var result = sqlCommand.ExecuteNonQuery() >= 0;
            Connection.Close();

            return result;
        }

        public override bool Update(Vehicle vehicle)
        {
            var sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "Update Vehicle SET ";

            sqlCommand.CommandText += $"Color='{vehicle.Color}', Wear='{vehicle.Wear}',  Brand='{vehicle.Brand}', Model='{vehicle.Model}', Type='{vehicle.Type}', " +
                                      $"Year='{vehicle.Year}', StatusId='{(int)vehicle.Status}', SizeId='{(int)vehicle.Size}', Cost={vehicle.Cost} ";
            sqlCommand.CommandText += $"WHERE Id='{vehicle.Id}'";
            Connection.Open();

            var result = sqlCommand.ExecuteNonQuery() >= 0;
            Connection.Close();

            return result;
        }

        public override IList<Vehicle> Read()
        {
            List<Vehicle> result = new List<Vehicle>();

            var sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Vehicle";
            Connection.Open();

            using (var sqlReader = sqlCommand.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    result.Add(new Vehicle
                    {
                        Id = sqlReader.GetInt32(sqlReader.GetOrdinal("Id")),
                        Brand = sqlReader.GetString(sqlReader.GetOrdinal("Brand")),
                        Color = sqlReader.GetString(sqlReader.GetOrdinal("Color")),
                        Wear = sqlReader.GetString(sqlReader.GetOrdinal("Wear")),
                        Model = sqlReader.GetString(sqlReader.GetOrdinal("Model")),
                        Year = sqlReader.GetInt32(sqlReader.GetOrdinal("Year")),
                        Status = (VehicleStatus)sqlReader.GetInt32(sqlReader.GetOrdinal("StatusId")),
                        Size = (VehicleSize)sqlReader.GetInt32(sqlReader.GetOrdinal("SizeId")),
                        Type = sqlReader.GetString(sqlReader.GetOrdinal("Type")),
                        Cost = sqlReader.GetInt32(sqlReader.GetOrdinal("Cost")),
                    });
                }
            }

            Connection.Close();

            return result;
        }
    }
}