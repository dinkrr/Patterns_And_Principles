using System.Collections.Generic;

namespace CreationalPatterns.Factory.B_FactoryMethod
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public abstract IPizza CreatePizza(IList<string> ingredients);
    }

    public class DominosPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            //This is tied to a specific pizza implementation
            return new DominosPizza(ingredients);
        }
    }

    public class PizzaHutStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            //This is tied to a specific pizza implementation
            return new PizzaHut(ingredients);
        }
    }
}
