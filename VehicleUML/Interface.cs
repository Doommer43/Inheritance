using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUML
{

    public interface Interface
    {
        bool HasWheels { get; set; }
        bool IsAbleToDrive { get; set; }
        decimal Price { get; set; }
    }
}
