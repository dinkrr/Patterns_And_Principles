using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructuralPatterns.Facade;

namespace StructuralPatternsTests.Facade
{
    [TestClass]
    public class MortgageTests
    {
        Customer customer;
        MortgageService mortgageService;

        [TestInitialize]
        public void Initialize()
        {
            customer = new Customer("Suraj");
            mortgageService = new MortgageService();
        }

        [TestMethod]
        [DataRow(10000, true)]
        public void IsEligibleTest(int amount, bool actuallyIsEligible)
        {
            bool isEligible = mortgageService.IsEligible(customer, amount);
            Assert.IsTrue(isEligible);
            Assert.AreEqual(actuallyIsEligible, isEligible);
        }
    }
}
