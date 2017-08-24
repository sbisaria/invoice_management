using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileServiceProvider
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string ModelNo { get; set; }
        public string ChasisNo { get; set; }
        public Color VehicleColor { get; set; }
        public Gear Gear { get; set; }
        public Type Category { get; set; }

        public Vehicle(string name, string modelNo, string chasisNo, Color vehicleColor, Gear gear, Type category)
        {
            Name = name;
            ModelNo = modelNo;
            ChasisNo = chasisNo;
            VehicleColor = vehicleColor;
            Gear = gear;
            Category = category;
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            var name = $"Name : {Name}";
            var modelNo = $"Model No : {ModelNo}";
            var chasisNo = $"Chasis No : {ChasisNo}";
            var vehicleColor = $"Vehicle Color :{VehicleColor}";
            var gear = $" Gear: {Gear}";
            str.Append(name).Append("\n").Append(modelNo).Append("\n").Append(chasisNo);
            return str.ToString();
        }
    }
    
}
