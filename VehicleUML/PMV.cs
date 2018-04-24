using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{
    class PMV : BeltedVehicle
    {
        private int amountOfPassengers;
        private bool IsAmphibious;

        public PMV(bool HasWheels, bool IsAbleToDrive, int amountOfWheels, int beltLength, int beltWidth, int weight, int horsePower, int amountOfPassengers, bool isAmphibious) :
            base(HasWheels, IsAbleToDrive, amountOfWheels, beltLength, beltWidth, weight, horsePower)
        {
            this.amountOfPassengers = amountOfPassengers;
            IsAmphibious = isAmphibious;
        }

        public string DriveThroughTerrain()
        {
            return $"The PMV succesfully delivered its {amountOfPassengers} to their destination.";
        }
    }
}
