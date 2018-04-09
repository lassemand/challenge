using System;

namespace VacationCost
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new CommandLineInterpreter(args);
            if (interpreter.VacationCostModel == null)
                return;

            var calculator = new VacationCostCalculator(interpreter.VacationCostModel);
            var result = calculator.CostOfVacation();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
