using CreationalPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreationalPatternsTests.SingletonTests
{
	[TestClass]
	public class SingletonTest
	{
		[TestMethod]
		public void ShouldCreateJustOneInstance()
		{
			var productInstance1 = SingletonProduct.Instance;
			var productInstance2 = SingletonProduct.Instance;
			Assert.AreSame(productInstance1, productInstance2);

			productInstance1.ProductValue++;
			Assert.AreEqual(productInstance1.ProductValue, productInstance2.ProductValue);

			productInstance2.ProductValue++;
			Assert.AreEqual(productInstance1.ProductValue, productInstance2.ProductValue);
		}
	}
}
