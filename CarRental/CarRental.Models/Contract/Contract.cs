using System;
using System.Collections.Generic;

namespace CarRental.Models.Contract
{
    public class Contract
    {
        public int Id { get; set; }
        public Customer.Customer Customer { get; set; }
        public Vehicle.Vehicle Vehicle { get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public double DiscountSum { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ContractStatus ContractStatus { get; set; }

        public static List<Contract> Contracts = InitialContractsList();

        public static List<Contract> InitialContractsList()
        {
            return new List<Contract>
            {
                new Contract
                {
                    Customer = Models.Customer.Customer.Customers[0],
                    Vehicle = Models.Vehicle.Vehicle.Vehicles[0],
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
                    Customer = Models.Customer.Customer.InitialCustomersList()[0],
                    Vehicle = Models.Vehicle.Vehicle.InitialVehiclesList()[1],
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
                    Customer = Models.Customer.Customer.InitialCustomersList()[1],
                    Vehicle = Models.Vehicle.Vehicle.InitialVehiclesList()[2],
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
                    Customer = Models.Customer.Customer.InitialCustomersList()[1],
                    Vehicle = Models.Vehicle.Vehicle.InitialVehiclesList()[3],
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
                    Customer = Models.Customer.Customer.InitialCustomersList()[0],
                    Vehicle = Models.Vehicle.Vehicle.InitialVehiclesList()[4],
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
                    Customer = Models.Customer.Customer.InitialCustomersList()[1],
                    Vehicle = Models.Vehicle.Vehicle.InitialVehiclesList()[5],
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
                    Customer = Models.Customer.Customer.InitialCustomersList()[1],
                    Vehicle = Models.Vehicle.Vehicle.InitialVehiclesList()[6],
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
}