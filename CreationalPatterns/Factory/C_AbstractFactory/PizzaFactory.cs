using System.Collections.Generic;

namespace CreationalPatterns.Factory.C_AbstractFactory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(IList<string> ingredients);
    }

    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> ingredients);
    }

    public class DominosPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new DominosPizza(ingredients);
        }
    }

    public class PizzaHutFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new PizzaHut(ingredients);
        }
    }
}
