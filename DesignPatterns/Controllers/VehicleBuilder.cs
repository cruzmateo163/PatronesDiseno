using DesignPatterns.Models;
using System;

namespace DesignPatterns.Controllers
{
    public class VehicleBuilder
    {
        private readonly Vehicle _vehicle;

        public VehicleBuilder()
        {
            //_vehicle = new Vehicle();
            _vehicle.Year = DateTime.Now.Year;
        
        }

        public VehicleBuilder WithColor(string color)
        {
            _vehicle.Color = color;
            return this;
        }

        public VehicleBuilder WithBrand(string brand)
        {
            _vehicle.Brand = brand;
            return this;
        }

        public VehicleBuilder WithModel(string model)
        {
            _vehicle.Model = model;
            return this;
        }

        public Vehicle Build()
        {
            return _vehicle;
        }








    }

}
