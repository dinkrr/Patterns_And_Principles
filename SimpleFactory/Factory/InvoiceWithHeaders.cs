using System;
using SimpleFactory.Invoice;

namespace SimpleFactory.Factory
{
	public class InvoiceWithHeaders : IInvoice
	{
		public void Print()
		{
			Console.WriteLine("Printed Invoice With Headers!");
		}
	}
}