using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{
    public class WheeledVehicle : Interface
    {
        public bool HasWheels { get; set; }
        public bool IsAbleToDrive { get; set; }
        public decimal Price { get; set; }

        private int amountOfWheels;
        private int wheelSize;

        public WheeledVehicle(int wheelSize, bool HasWheels = true, bool IsAbleToDrive = true, int amountOfWheels = 4)
        {
            this.HasWheels = HasWheels;
            this.IsAbleToDrive = IsAbleToDrive;
            this.amountOfWheels = amountOfWheels;
            this.wheelSize = wheelSize;
        }

        public string Drive()
        {
            return $"The vehicle used {amountOfWheels} wheels to drive <<forward>>";
        }
    }
}
