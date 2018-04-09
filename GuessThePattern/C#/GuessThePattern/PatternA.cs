using System;

namespace GuessThePattern
{
    public class PatternA
    {
        private static PatternA _instance;
        private PatternA()
        {
        }

        public static PatternA GetInstance()
        {
            if (_instance == null)
                _instance = new PatternA();

            return _instance;
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}

/* Write your answers and comments below this line
    Pattern: Singleton
    Pros:
    1. It is not desirable have multiple object which each share some part of state
    Cons:
    1. An obvious problem is that this only work in a synchronous manner. In order for it to work in parallel, some shared state amongst the processes must shared.
    2. A singleton class has problems with being sub classed
    3. Singleton object can hide dependencies, because the initialisation is hidden to us
*/
