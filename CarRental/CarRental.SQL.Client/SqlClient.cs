using System;
using CarRental.Models.Vehicle;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CarRental.SQL.Client
{
    public static class SqlClient
    {
        private static readonly MySqlConnection Conn;

        static SqlClient()
        {
            Conn = new MySqlConnection("Server=sql11.freesqldatabase.com;User Id=sql11174816;Password=IaU27AFvtI;Database=sql11174816;");

        }

        public static List<Vehicle> GetVehiclesList()
        {
            List<Vehicle> result = new List<Vehicle>();

            var sqlCommand = Conn.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Vehicle";
            Conn.Open();

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
                        Status = (VehicleStatus) sqlReader.GetInt32(sqlReader.GetOrdinal("StatusId")),
                        Size = (VehicleSize) sqlReader.GetInt32(sqlReader.GetOrdinal("SizeId")),
                        Type = sqlReader.GetString(sqlReader.GetOrdinal("Type")),
                        Cost = sqlReader.GetInt32(sqlReader.GetOrdinal("Cost")),
                    });
                }
            }

            Conn.Close();

            return result;
        }

        public static bool AddVehicle(Vehicle vehicle)
        {
            var sqlCommand = Conn.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO Vehicle (`Id`, `Color`, `Wear`, `Brand`, `Model`, `Type`, `Year`, `StatusId`, `SizeId`, `Cost`) VALUES";

            sqlCommand.CommandText += $"(NULL, '{vehicle.Color}', '{vehicle.Wear}', '{vehicle.Brand}', '{vehicle.Model}', '{vehicle.Type}', " +
                                      $"'{vehicle.Year}', '{(int)vehicle.Status}', '{(int)vehicle.Size}', '{vehicle.Cost}');";
            Conn.Open();

            var result = sqlCommand.ExecuteNonQuery() >= 0;
            Conn.Close();

            return result;
        }

        public static bool UpdateVehicle(Vehicle vehicle)
        {
            var sqlCommand = Conn.CreateCommand();
            sqlCommand.CommandText = "Update Vehicle SET ";

            sqlCommand.CommandText += $"`Color`='{vehicle.Color}', `Wear`='{vehicle.Wear}',  `Brand`='{vehicle.Brand}', `Model`='{vehicle.Model}', `Type`='{vehicle.Type}', " +
                                      $"`Year`='{vehicle.Year}', `StatusId`='{(int)vehicle.Status}', `SizeId`='{(int)vehicle.Size}', `Cost`={vehicle.Cost} ";
            sqlCommand.CommandText += $"WHERE Id='{vehicle.Id}'";
            Conn.Open();

            var result = sqlCommand.ExecuteNonQuery() >= 0;
            Conn.Close();

            return result;
        }
    }
}
