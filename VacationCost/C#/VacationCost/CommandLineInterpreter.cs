using System;
using System.Xml.Schema;

namespace VacationCost
{
    public class CommandLineInterpreter
    {
        private bool _validInput = true;

        public CommandLineInterpreter(string[] arguments)
        {
            VacationCostModel = ValidateInput(arguments);
        }

        private void ValidateInputLength(string[] arguments)
        {
            if (arguments.Length < 2)
                CreateErrorMessage("Not enough input arguments to run this program");
        }

        private VacationTransportMethod ValidateTransportationMode(string firstArgument)
        {
            VacationTransportMethod transportMethod;
            if (!Enum.TryParse(firstArgument, true, out transportMethod))
                CreateErrorMessage("Invalid transportation format");
            return transportMethod;
        }

        private double ValidateDistance(string secondArgument)
        {
            double distance;
            if (!double.TryParse(secondArgument, out distance))
                CreateErrorMessage("Invalid distance format");
            return distance;
        }

        private VacationCostModel ValidateInput(string[] arguments)
        {
            ValidateInputLength(arguments);
            var transportMethod = ValidateTransportationMode(arguments[0]);
            var distance = ValidateDistance(arguments[1]);
            if (_validInput)
                return new VacationCostModel(transportMethod, distance);
            return null;
        }

        private void CreateErrorMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
            _validInput = false;
        }

        public VacationCostModel VacationCostModel { get; }
    }
}
