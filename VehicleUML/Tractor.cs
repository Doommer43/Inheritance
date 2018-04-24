using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{
    class Tractor : WheeledVehicle
    {
        private int horsePower;
        private bool hasPassengerSeat;
        private int height;
        private int wheelHeight;
        private int fuelVolume;
        public Tractor(bool HasWheels, bool IsAbleToDrive, int amountOfWheels, int horsePower, bool hasPassengerSeat, int height, int wheelHeight, int fuelVolume):
            base(wheelHeight, HasWheels, IsAbleToDrive, amountOfWheels)
        {
            this.horsePower = horsePower;
            this.hasPassengerSeat = hasPassengerSeat;
            this.height = height;
            this.wheelHeight = wheelHeight;
            this.fuelVolume = fuelVolume;
        }

        public string Refuel(int amount)
        {
            fuelVolume += amount;
            return $"The tractor has been refueled with {amount} for a total of {fuelVolume}.";
        }
    }
}
