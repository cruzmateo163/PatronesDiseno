using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class MockVehicleRepository : IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles;

        public MockVehicleRepository()
        {
            _vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }

        ICollection<Vehicle> IVehicleRepository.GetVehicles()
        {
            throw new NotImplementedException();
        }

    }


}
