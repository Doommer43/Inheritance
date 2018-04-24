using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{
    public class Tank : BeltedVehicle
    {
        static Random rnd = new Random();
        private int battelLength;
        private decimal mainGunCaliber;

        public Tank(bool HasWheels, bool IsAbleToDrive, int amountOfWheels, int beltLength, int beltWidth, int weight, int horsePower, int battelLength, decimal mainGunCaliber) :
            base(HasWheels, IsAbleToDrive, amountOfWheels, beltLength, beltWidth, weight, horsePower)
        {
            this.battelLength = battelLength;
            this.mainGunCaliber = mainGunCaliber;
        }

        public List<string> FireMainGun(int amountOfTimes)
        {
            List<string> shots = new List<string>();
            for (int i = 0; i < amountOfTimes; i++)
            {
                if(rnd.Next() == 1)
                {
                    shots.Add("The tank fired it main gun and HIT the target.");
                } else
                {
                    shots.Add("The tank fired it main gun and MISSED the target.");
                }
            }
            return shots;
        }
    }
}
