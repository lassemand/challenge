using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCost
{
    public class VacationCostModel
    {
        public VacationTransportMethod TransportMethod { get; private set; }
        public double Distance { get; private set; }

        public VacationCostModel(VacationTransportMethod transportMethod, double distance)
        {
            TransportMethod = transportMethod;
            Distance = distance;
        }
    }
}
