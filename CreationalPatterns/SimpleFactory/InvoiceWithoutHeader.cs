using System;

namespace CreationalPatterns.SimpleFactory
{
	public class InvoiceWithoutHeader : IInvoice
	{
		public void Print()
		{
			Console.WriteLine("Printed Invoice With Headers!");
		}
	}
}