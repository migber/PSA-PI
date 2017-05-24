using System.Collections.Generic;
using CarRental.Models.Contract;
using CarRental.Models;
using CarRental.Models.Vehicle;
using System.Linq;
using CarRental.SQL.Client.MemoryClient;
using CarRental.Models.Customer;

namespace CarRental.SQL.Client.SqlClient
{
    public class ContractClient : SqlClient<Contract>
    {
        private IClient<Vehicle> _client = new VehicleClient();
        private IClient<Customer> _customerClient = new CustomerClient();

        public override bool Create(Contract contract)
        {
            var sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO `Contract`(`Id`, `CustomerId`, `VehicleId`, `ContractDate`, `PickupDate`, `ReturnDate`, `Comment`, `Price`, `Discount`, `DiscountSum`, `PaymentMethodId`, `ContractStatusId`) VALUES";

            sqlCommand.CommandText += $"(NULL, '{contract.CustomerId}', '{contract.VehicleId}', '{contract.ContractDate}', '{contract.PickupDate}', '{contract.ReturnDate}', " +
                                      $"'{contract.Comment}', '{contract.Price}', '{contract.Discount}', '{contract.DiscountSum}' , '{contract.PaymentMethod}' , '{contract.ContractStatus}');";
            Connection.Open();

            var result = sqlCommand.ExecuteNonQuery() >= 0;
            Connection.Close();

            return result;
        }

        public override bool Update(Contract contract)
        {
            var sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "Update `Contract` SET ";

            sqlCommand.CommandText += $"`CustomerId`={contract.CustomerId}, `VehicleId`={contract.VehicleId},`ContractDate`={contract.ContractDate},`PickupDate`={contract.PickupDate}, " +
                                      $"`ReturnDate`={contract.ReturnDate},`Comment`={contract.Comment},`Price`={contract.Price},`Discount`={contract.Discount},`DiscountSum`={contract.DiscountSum},`PaymentMethodId`={contract.PaymentMethod},`ContractStatusId`={contract.ContractStatus}";
            sqlCommand.CommandText += $"WHERE Id='{contract.Id}'";
            Connection.Open();

            var result = sqlCommand.ExecuteNonQuery() >= 0;
            Connection.Close();

            return result;
        }

        public override IList<Contract> Read()
        {
            List<Contract> result = new List<Contract>();

            var sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Contract";
            Connection.Open();

            using (var sqlReader = sqlCommand.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    var sqlResult = new Contract
                    {

                        Id = sqlReader.GetInt32(sqlReader.GetOrdinal("Id")),
                        CustomerId = sqlReader.GetInt32(sqlReader.GetOrdinal("CustomerId")),
                        PickupDate = sqlReader.GetDateTime(sqlReader.GetOrdinal("PickupDate")),
                        ReturnDate = sqlReader.GetDateTime(sqlReader.GetOrdinal("ReturnDate")),
                        ContractDate = sqlReader.GetDateTime(sqlReader.GetOrdinal("ContractDate")),
                        VehicleId = sqlReader.GetInt32(sqlReader.GetOrdinal("VehicleId")),
                        DiscountSum = sqlReader.GetInt32(sqlReader.GetOrdinal("DiscountSum")),
                        PaymentMethod = (PaymentMethod)sqlReader.GetInt32(sqlReader.GetOrdinal("PaymentMethodId")),
                        ContractStatus = (ContractStatus)sqlReader.GetInt32(sqlReader.GetOrdinal("ContractStatusId")),
                        Comment = sqlReader.GetString(sqlReader.GetOrdinal("Comment")),
                        Discount = sqlReader.GetInt32(sqlReader.GetOrdinal("Discount")),
                        Price = sqlReader.GetInt32(sqlReader.GetOrdinal("Price"))
                    };

                    sqlResult.Vehicle = _client.Read().FirstOrDefault(v => v.Id == sqlResult.VehicleId);
                    sqlResult.Customer = _customerClient.Read().FirstOrDefault(v => v.Id == sqlResult.CustomerId);
                    
                    result.Add(sqlResult);
                }
            }

            Connection.Close();

            return result;
        }
    }
}