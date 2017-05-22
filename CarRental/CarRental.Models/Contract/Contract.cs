using System;
using System.Collections.Generic;

namespace CarRental.Models.Contract
{
    public class Contract : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer.Customer Customer { get; set; }
        public int VehicleId { get; set; }
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

        
    }
}