using System;

namespace VacationCost
{
    public class VacationCostCalculator
    {
        public VacationCostModel VacationCostModel { get; }

        public VacationCostCalculator(VacationCostModel vacationCostModel)
        {
            VacationCostModel = vacationCostModel;
        }

        public decimal CostOfVacation()
        {
            switch (VacationCostModel.TransportMethod)
            {
                case VacationTransportMethod.Car:
                    return (decimal) (VacationCostModel.Distance * 1);
                case VacationTransportMethod.Plane:
                    return (decimal) (VacationCostModel.Distance * 2);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
