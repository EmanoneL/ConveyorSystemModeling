using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СonveyorSystemModeling
{

    enum Statuses
    {
        Raw = 0,
        Prosecced = 1      
    }
    class Detail
    {
        Statuses Status { get; set; }
        Detail()
        {
            Status = Statuses.Raw;
        }
    }
}
