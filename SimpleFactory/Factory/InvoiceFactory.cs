using SimpleFactory.Invoice;

namespace SimpleFactory.Factory
{
	public enum InvoiceType
	{
		WithHeaders,
		WithoutHeaders
	}

	public class InvoiceFactory
	{
		public static IInvoice GetInvoice(InvoiceType invoiceType)
		{
			IInvoice invoice;
			switch (invoiceType)
			{
				case InvoiceType.WithHeaders:
					invoice = new InvoiceWithHeaders();
					break;
				case InvoiceType.WithoutHeaders:
					invoice = new InvoiceWithoutHeader();
					break;
				default:
					invoice = null;
					break;
			}
			return invoice;
		}
	}
}