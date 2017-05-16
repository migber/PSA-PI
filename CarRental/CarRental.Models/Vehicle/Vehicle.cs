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
    }
}