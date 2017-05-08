using System.Collections.Generic;

namespace CarRental.Models.Vehicle
{
    public class Vehicle
    {
        public Vehicle(int year, int cost)
        {
            Year = year;
            Cost = cost;
        }

        public Vehicle()
            :this(2000, 50)
        {}

        public int Id { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }
        public string Wear { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public VehicleStatus Status { get; set; }
        public VehicleSize Size { get; set; }
        public string DisplayName => Brand + " " + Model;

        public static List<Vehicle> Vehicles = InitialVehiclesList();

        public static List<Vehicle> InitialVehiclesList()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Brand = "Ford",
                    Model = "Fiesta",
                    Color = "Black",
                    Cost = 75,
                    Size = VehicleSize.S,
                    Status = VehicleStatus.Free,
                    Type = "Hachback",
                    Wear = "Minimal",
                    Year = 2009,
                    Id = 1
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "Passat",
                    Color = "Silver",
                    Cost = 110,
                    Size = VehicleSize.L,
                    Status = VehicleStatus.Free,
                    Type = "Sedan",
                    Wear = "Minimal",
                    Year = 2011,
                    Id = 2
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "Passat",
                    Color = "Silver",
                    Cost = 115,
                    Size = VehicleSize.L,
                    Status = VehicleStatus.UnderRepair,
                    Type = "Sedan",
                    Wear = "Minimal",
                    Year = 2009,
                    Id = 3
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "Golf",
                    Color = "Black",
                    Cost = 49,
                    Size = VehicleSize.M,
                    Status = VehicleStatus.Free,
                    Type = "Hachback",
                    Wear = "None",
                    Year = 2010,
                    Id = 4
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "Touran",
                    Color = "Silver",
                    Cost = 139,
                    Size = VehicleSize.XL,
                    Status = VehicleStatus.Free,
                    Type = "SUV",
                    Wear = "Minimal",
                    Year = 2009,
                    Id = 5
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "A6",
                    Color = "Black",
                    Cost = 129,
                    Size = VehicleSize.XL,
                    Status = VehicleStatus.InUse,
                    Type = "Sedan",
                    Wear = "Minimal",
                    Year = 2008,
                    Id = 6
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "A3",
                    Color = "Silver",
                    Cost = 100,
                    Size = VehicleSize.S,
                    Status = VehicleStatus.Free,
                    Type = "Hachback",
                    Wear = "Minimal",
                    Year = 2015,
                    Id = 7
                },
                new Vehicle
                {
                    Brand = "Volkswagen",
                    Model = "Q3",
                    Color = "Yellow",
                    Cost = 155,
                    Size = VehicleSize.L,
                    Status = VehicleStatus.InUse,
                    Type = "SUV",
                    Wear = "Minimal",
                    Year = 2013,
                    Id = 8
                },
                new Vehicle
                {
                    Brand = "BMW",
                    Model = "330",
                    Color = "Blue",
                    Cost = 119,
                    Size = VehicleSize.M,
                    Status = VehicleStatus.Free,
                    Type = "Sedan",
                    Wear = "Minimal",
                    Year = 2008,
                    Id = 9
                },
                new Vehicle
                {
                    Brand = "BMW",
                    Model = "750",
                    Color = "Black",
                    Cost = 230,
                    Size = VehicleSize.L,
                    Status = VehicleStatus.Free,
                    Type = "Sedan",
                    Wear = "Minimal",
                    Year = 2010,
                    Id = 10
                },
                new Vehicle
                {
                    Brand = "Mercedes-Benz",
                    Model = "E250",
                    Color = "Blue",
                    Cost = 145,
                    Size = VehicleSize.L,
                    Status = VehicleStatus.InUse,
                    Type = "Sedan",
                    Wear = "Minimal",
                    Year = 2013,
                    Id = 11
                },

            };

            return vehicles;
        }
    }
}