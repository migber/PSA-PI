using System;
using System.Collections.Generic;
using System.Linq;
using CarRental.Models;
using CarRental.Models.Contract;
using CarRental.Models.Customer;

namespace CarRental.SQL.Client.MemoryClient
{
    public class ContractsClient : MemoryClient<Contract>
    {
        static readonly IClient<Customer> _customersClient = new CustomerClient();

        public override bool Create(Contract entity)
        {
            Contracts.Add(entity);

            return true;
        }

        public override bool Update(Contract entity)
        {
            Contracts.Remove(Contracts.FirstOrDefault(c => c.Id == entity.Id));
            Create(entity);

            return true;
        }

        public override IList<Contract> Read()
        {
            return Contracts;
        }

        private readonly List<Contract> Contracts =new List<Contract>
            {
                new Contract
                {
                    Customer = _customersClient.Read()[0],
                    VehicleId = 1,
                    PaymentMethod = PaymentMethod.Cash,
                    Comment = "",
                    ContractDate = new DateTime(2017, 5, 31),
                    ContractStatus = ContractStatus.Ordered,
                    Discount = 0,
                    DiscountSum = 0,
                    Id = 1,
                    PickupDate = new DateTime(2017, 6, 15),
                    Price = 189,
                    ReturnDate = new DateTime(2017, 7, 15)
                },
                new Contract
                {
                    Customer = _customersClient.Read()[0],
                    VehicleId = 2,
                    PaymentMethod = PaymentMethod.Cash,
                    Comment = "",
                    ContractDate = new DateTime(2017, 2, 19),
                    ContractStatus = ContractStatus.Approved,
                    Discount = 10,
                    DiscountSum = 19,
                    Id = 2,
                    PickupDate = new DateTime(2017, 9, 02),
                    Price = 219,
                    ReturnDate = new DateTime(2017, 9, 29)
                },
                new Contract
                {
                    Customer = _customersClient.Read()[1],
                    VehicleId = 3,
                    PaymentMethod = PaymentMethod.BankTransaction,
                    Comment = "Client is very annoying.",
                    ContractDate = new DateTime(2017, 01, 14),
                    ContractStatus = ContractStatus.Ordered,
                    Discount = 0,
                    DiscountSum = 0,
                    Id = 3,
                    PickupDate = new DateTime(2017, 02, 15),
                    Price = 230,
                    ReturnDate = new DateTime(2017, 03, 01)
                },
                new Contract
                {
                    Customer = _customersClient.Read()[1],
                    VehicleId = 4,
                    PaymentMethod = PaymentMethod.Cash,
                    Comment = "",
                    ContractDate = new DateTime(2016, 12, 12),
                    ContractStatus = ContractStatus.Ordered,
                    Discount = 0,
                    DiscountSum = 0,
                    Id = 4,
                    PickupDate = new DateTime(2016, 12, 25),
                    Price = 75,
                    ReturnDate = new DateTime(2016, 12, 29)
                },
                new Contract
                {
                    Customer = _customersClient.Read()[0],
                    VehicleId = 5,
                    PaymentMethod = PaymentMethod.Cash,
                    Comment = "",
                    ContractDate = new DateTime(2017, 5, 31),
                    ContractStatus = ContractStatus.Ordered,
                    Discount = 0,
                    DiscountSum = 0,
                    Id = 5,
                    PickupDate = new DateTime(2017, 05, 06),
                    Price = 180,
                    ReturnDate = new DateTime(2017, 06, 15)
                },
                new Contract
                {
                    Customer = _customersClient.Read()[1],
                    VehicleId = 6,
                    PaymentMethod = PaymentMethod.Cash,
                    Comment = "",
                    ContractDate = new DateTime(2017, 11, 21),
                    ContractStatus = ContractStatus.Ordered,
                    Discount = 0,
                    DiscountSum = 0,
                    Id = 6,
                    PickupDate = new DateTime(2017, 7, 13),
                    Price = 39,
                    ReturnDate = new DateTime(2017, 7, 15)
                },
                new Contract
                {
                    Customer = _customersClient.Read()[1],
                    VehicleId = 7,
                    PaymentMethod = PaymentMethod.Cash,
                    Comment = "",
                    ContractDate = new DateTime(2017, 5, 31),
                    ContractStatus = ContractStatus.Ordered,
                    Discount = 0,
                    DiscountSum = 0,
                    Id = 7,
                    PickupDate = new DateTime(2017, 9, 10),
                    Price = 260,
                    ReturnDate = new DateTime(2017, 9, 15)
                }
            };
    }
}