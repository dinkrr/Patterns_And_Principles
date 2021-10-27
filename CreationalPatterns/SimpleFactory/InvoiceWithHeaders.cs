using System;

namespace CreationalPatterns.SimpleFactory
{
	public class InvoiceWithHeaders : IInvoice
	{
		public void Print()
		{
			Console.WriteLine("Printed Invoice With Headers!");
		}
	}
}