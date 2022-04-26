using System.Collections.Generic;

namespace CreationalPatterns.Factory.C_AbstractFactory
{
    public abstract class PizzaStoreWithAbstractFactory
    {
        private readonly IPizzaFactory _factory;

        protected PizzaStoreWithAbstractFactory(IPizzaFactory factory)
        {
            _factory = factory;
        }

        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = _factory.CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class DominosPizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public DominosPizzaStoreWithAbstractFactory() : this(new DominosPizzaFactory())
        { }

        public DominosPizzaStoreWithAbstractFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        { }
    }

    public class PizzaHutStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public PizzaHutStoreWithAbstractFactory() : this(new PizzaHutFactory())
        { }

        public PizzaHutStoreWithAbstractFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        { }
    }
}
