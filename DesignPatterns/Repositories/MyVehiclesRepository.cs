using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private static MyVehiclesRepository _instance;
        private static readonly object _lock = new object();

        private readonly ICollection<Vehicle> _memoryCollection;

        private MyVehiclesRepository()
        {
            _memoryCollection = new List<Vehicle>();
        }

        public static MyVehiclesRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MyVehiclesRepository();
                        }
                    }
                }
                return _instance;
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            return _memoryCollection.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _memoryCollection;
        }
    }

}
