using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СonveyorSystemModeling
{
    class ConveyorLine
    {
        int devicesNumer = 5;
        ServiceDevice[] devices;
        int intensity = 15; // one detail per 15 seconds
        int followInterval = 60; // one detail follow from one ServiceDevice to another
    }
}
