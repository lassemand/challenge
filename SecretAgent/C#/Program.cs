using System;

namespace SecretAgent
{
	class Program
	{
        static void Main(string[] args)
        {
            var secretAgent = new FindSecretAgent();
            var result = secretAgent.StartSearch(new[] { 1,2,3,4,4});
            Console.WriteLine(result);
            Console.ReadLine();
		}
	}
}
