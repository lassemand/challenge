using System;
using System.Collections.Generic;

namespace Graf
{
    public class Finder : IFinder
    {
        public string FromRight(Customers customers, int numberFromRight)
        {
            return FromRightRecursion(customers, numberFromRight, new Queue<string>());
        }

        private string FromRightRecursion(Customers customers, int numberFromRight, Queue<string> customerQueue, int counter = 0)
        {
            var customerExists = customers != null;
            if(customerExists)
                customerQueue.Enqueue(customers.Person);

            var isListBigEnough = counter == numberFromRight;
            if(isListBigEnough)
            {
                var customer = customerQueue.Dequeue();
                return !customerExists ? customer : FromRightRecursion(customers.Next, numberFromRight, customerQueue, counter);
            }

            var isListEmpty = customerExists && counter < numberFromRight;
            if (isListEmpty)
                return FromRightRecursion(customers.Next, numberFromRight, customerQueue, counter + 1);
            return null;
        }
    }
}
