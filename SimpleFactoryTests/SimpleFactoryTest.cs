using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactory.Factory;

namespace SimpleFactoryTests
{
	[TestClass]
	public class SimpleFactoryTest
	{
		[TestMethod]
		public void ShouldCreateInvoiceTypeWithHeaders()
		{
			var invoice = InvoiceFactory.GetInvoice(InvoiceType.WithHeaders);
			Assert.IsNotNull(invoice as InvoiceWithHeaders);
		}

		[TestMethod]
		public void ShouldCreateInvoiceTypeWithoutHeaders()
		{
			var invoice = InvoiceFactory.GetInvoice(InvoiceType.WithoutHeaders);
			Assert.IsNotNull(invoice as InvoiceWithoutHeader);
		}
	}
}
