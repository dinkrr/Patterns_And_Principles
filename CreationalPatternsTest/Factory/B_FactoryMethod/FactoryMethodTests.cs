using CreationalPatterns.Factory;
using CreationalPatterns.Factory.B_FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CreationalPatternsTests.Factory.B_FactoryMethod
{
    [TestClass]
    public class FactoryMethodTests
    {
        [TestMethod]
        public void ShouldCreateSpecificDominosPizza()
        {
            var pizza = new DominosPizzaStore().OrderPizza(new List<string>());
            Assert.IsNotNull(pizza as DominosPizza);
        }
        
        [TestMethod]
        public void ShouldCreateSpecificPizzaHutPizza()
        {
            var pizza = new PizzaHutStore().OrderPizza(new List<string>());
            Assert.IsNotNull(pizza as PizzaHut);
        }
    }
}
