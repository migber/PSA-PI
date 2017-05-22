using System;
using System.Collections.Generic;
using System.Linq;
using CarRental.Models.Customer;

namespace CarRental.SQL.Client.MemoryClient
{
    public class CustomerClient : MemoryClient<Customer>
    {
        public override bool Create(Customer entity)
        {
            Customers.Add(entity);

            return true;
        }

        public override bool Update(Customer entity)
        {
            Customers.Remove(Customers.FirstOrDefault(c => c.Id == entity.Id));
            Create(entity);

            return true;
        }

        public override IList<Customer> Read()
        {
            return Customers;
        }

        private static readonly List<Customer> Customers = InitialCustomersList();

        private static List<Customer> InitialCustomersList()
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