using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{
    public class BeltedVehicle : Interface
    {
        public bool HasWheels { get; set; }
        public bool IsAbleToDrive { get; set; }
        public decimal Price { get; set; }

        private int beltLength;
        private int beltWidth;
        private int weight;
        private int horsePower;

        public BeltedVehicle(bool HasWheels, bool IsAbleToDrive, int amountOfWheels, int beltLength, int beltWidth, int weight, int horsePower)
        {
            this.beltLength = beltLength;
            this.beltWidth = beltWidth;
            this.weight = weight;
            this.horsePower = horsePower;
        }
    }
}
