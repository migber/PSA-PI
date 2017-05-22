using System;
using System.Collections.Generic;

namespace CarRental.Models.Customer
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string PersonalCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public double DrivingExperience { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LastEdit { get; set; }
        public string EmailAddress { get; set; }
        public string Status { get; set; }
        public string Profile { get; set; }
        public string Address { get; set; }

        public string DisplayName => FirstName + " " + LastName;
    }
}
