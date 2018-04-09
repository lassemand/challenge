using System;
using System.Collections.Generic;

namespace SecretAgent
{
    public class FindSecretAgent : IFindSecretAgent
    {
        // This is BigTheta(1) memory point of view, and from a theoretical point of view it will not get faster than BigTheta(n). 



        public int StartSearch(IEnumerable<int> ids)
        {
            var counter = 0;
            var sum = 0;
            using (var enumerator = ids.GetEnumerator())
                while (enumerator.MoveNext())
                {
                    counter++;
                    sum += enumerator.Current;
                }
            return sum - (counter * (counter - 1)) / 2;
        }
    }
}
