namespace GuessThePattern
{
    public abstract class SomeObject
    {
    }

    public class ConcreteSomeObject : SomeObject
    {
    }

    public abstract class PatternB
    {
        public abstract SomeObject Create();
    }

    public class ConcretePatternB : PatternB
    {
        public override SomeObject Create()
        {
            return new ConcreteSomeObject();
        }
    }
}

/* Write your answers and comments below this line
    Pattern: Abstract Factory
    Pros: 
    1. Can hide specific implementation from a developer
    2. Divide responsibilities between multiple classes
    Cons: 
    1. Sometimes misused compared to simply using dependency injection     
*/
