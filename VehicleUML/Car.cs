using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{
    public class Car : WheeledVehicle
    {
        private int safetyRating;
        private int entrances;

        public Car(bool HasWheels, bool IsAbleToDrive, int amountOfWheels, int wheelSize, int safetyRating, int entrances):
            base(wheelSize, HasWheels , IsAbleToDrive ,amountOfWheels)
        {
            this.safetyRating = safetyRating;
            this.entrances = entrances;
        }

        public string GetSalesTale()
        {
            return $"A Tesla is always a good choice.";
        }
    }
}
