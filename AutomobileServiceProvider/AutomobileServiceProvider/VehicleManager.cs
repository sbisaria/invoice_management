using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileServiceProvider
{
    public class VehicleManager
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Vehicle> SoldVehicle { get; set; }
        public List<Vehicle> RentedVehicles { get; set; }
        
        public bool AddVehicle()
        {
           
            return true;
        }
        public bool RemoveVehicle()
        {
            
            return true;
        }
        public List<string> GetRentableVehicle()
        {
            foreach (vehicle in Vehicle)
                return ;

        }
        public List<Vehicle> GetRentedVehicle()
        {

        }
        public List<Vehicle> GetSoldVehicle()
        {
            return "";
        }
    }
}
