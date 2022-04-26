using System.Collections.Generic;

namespace CreationalPatterns.Factory.A_SimpleFactory
{
    public enum PizzaType
    {
        PizzaHut,
        DominosPizza
    }

    public static class SimplePizzaFactory
    {
        public static IPizza CreatePizza(PizzaType type, IList<string> ingredients)
        {
            switch (type)
            {
                case PizzaType.DominosPizza:
                    return new DominosPizza(ingredients);
                case PizzaType.PizzaHut:
                    return new PizzaHut(ingredients);
                default:
                    return null;
            }
        }
    }
}
