using System;
using System.Collections.Generic;

namespace CarRental.Models.Customer
{
    public class Customer
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

        public static List<Customer> Customers = InitialCustomersList();

        public static List<Customer> InitialCustomersList()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Address = "29th Street, 19-84, Manhattan",
                    BirthDate = new DateTime(1990, 01, 08),
                    DrivingExperience = 14,
                    EmailAddress = "User@gmail.com",
                    FirstName = "Tadas",
                    LastName = "Burbieris",
                    LastEdit = DateTime.Today,
                    PersonalCode = "39001087859",
                    PhoneNumber = "+37068745879",
                    Profile = "",
                    Status = "Ok"
                },
                new Customer
                {
                    Id = 2,
                    Address = "Veju g. 14, Kaunas",
                    BirthDate = new DateTime(1998, 01, 19),
                    DrivingExperience = 3,
                    EmailAddress = "Ted@gmail.com",
                    FirstName = "Marius",
                    LastName = "Rackauskas",
                    LastEdit = DateTime.Today,
                    PersonalCode = "39505478563",
                    PhoneNumber = "+37065874589",
                    Profile = "",
                    Status = "Ok"
                },
                new Customer
                {
                    Id = 3,
                    Address = "Juozapaviciaus pr. 174, Kaunas",
                    BirthDate = new DateTime(1979, 05, 14),
                    DrivingExperience = 21,
                    EmailAddress = "Juozas@gmail.com",
                    FirstName = "Juozas",
                    LastName = "Kulvietis",
                    LastEdit = DateTime.Today,
                    PersonalCode = "37952478563",
                    PhoneNumber = "+37065874525",
                    Profile = "",
                    Status = "Ok"
                },

            };
        }
    }
}
