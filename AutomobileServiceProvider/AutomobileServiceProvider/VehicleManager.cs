using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileServiceProvider
{
    public class VehicleManager
    {
        private List<Vehicle> Vehicles { get; }
        private List<Vehicle> SoldVehicles { get; }
        private List<Vehicle> RentedVehicles { get; }

        public VehicleManager()
        {
            Vehicles = new List<Vehicle>();
            SoldVehicles = new List<Vehicle>();
            SoldVehicles = new List<Vehicle>();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            return true;
        }
        public List<Vehicle> RemoveVehicle(string id)
        {
            var indexToRemove = Vehicles.FindIndex(x => x.Id.Equals(id));
            Vehicles.RemoveAt(indexToRemove);
            return Vehicles;
        }

        public List<Vehicle> GetRentableVehicles()
        {
            var rentableVehicles = Vehicles.Where(x => x.Category.Equals(Type.rentable)).ToList();
            return rentableVehicles;
        }
        public List<Vehicle> GetRentedVehicles()
        {
            return RentedVehicles;
        }
        public List<Vehicle> GetSoldVehicles()
        {
            return SoldVehicles;
        }
    }
}
