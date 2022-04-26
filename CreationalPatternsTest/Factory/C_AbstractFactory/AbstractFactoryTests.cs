using CreationalPatterns.Factory;
using CreationalPatterns.Factory.C_AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CreationalPatternsTests.Factory.C_AbstractFactory
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void ShouldUseAnAbstractFactoryToCreateDominosPizza()
        {
            var pizza = new DominosPizzaStoreWithAbstractFactory(
                new DominosPizzaFactory()).OrderPizza(new List<string>());
            Assert.IsNotNull(pizza as DominosPizza);
        }
        
        [TestMethod]
        public void ShouldUseAnAbstractFactoryToCreatePizzaHutPizza()
        {
            var pizza = new PizzaHutStoreWithAbstractFactory(
                new PizzaHutFactory()).OrderPizza(new List<string>());
            Assert.IsNotNull(pizza as PizzaHut);
        }
    }
}
