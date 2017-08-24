using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileServiceProvider
{
    public class Showroom
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string RegistrationNo { get; set; }
        public decimal Revenue { get; set; }
        public List<Vehicle> _vehicles;

        public Showroom()
        {
            _vehicles = new List<Vehicle>();
        }
        public 
    }
}
