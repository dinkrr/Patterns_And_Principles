using CreationalPatterns.Factory;
using CreationalPatterns.Factory.A_SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CreationalPatternsTests.Factory.A_SimpleFactory
{
    [TestClass]
    public class SimpleFactoryTests
    {
        [TestMethod]
        [DataRow(PizzaType.PizzaHut)]
        public void ShouldCreatePizzaHutPizza(PizzaType pizzaType)
        {
            var pizza = SimplePizzaFactory.CreatePizza(pizzaType, new List<string>());
            Assert.IsNotNull(pizza as PizzaHut);
        }

        [TestMethod]
        [DataRow(PizzaType.DominosPizza)]
        public void ShouldCreateDominosPizza(PizzaType pizzaType)
        {
            var pizza = SimplePizzaFactory.CreatePizza(pizzaType, new List<string>());
            Assert.IsNotNull(pizza as DominosPizza);
        }
    }
}
