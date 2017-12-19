using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
	public class InvoiceRepository
	{
		/// <summary>
		/// Retrieves the list of invoices. 
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public List<Invoice> Retrieve(int customerId)
		{
			List<Invoice> invoiceList = new List<Invoice>
			{
				new Invoice
				{	InvoiceId = 1,
					CustomerId = 1,
					InvoiceDate = new DateTime(2017, 6, 20),
					DueDate = new DateTime(2018, 6, 20),
					IsPaid = null },
				new Invoice
				{	InvoiceId = 2,
					CustomerId = 1,
					InvoiceDate = new DateTime(2017, 7, 20),
					DueDate = new DateTime(2018, 7, 20),
					IsPaid = null },
				new Invoice
				{	InvoiceId = 3,
					CustomerId = 2,
					InvoiceDate = new DateTime(2017, 7, 25),
					DueDate = new DateTime(2018, 7, 25),
					IsPaid = null },
				new Invoice
				{	InvoiceId = 4,
					CustomerId = 3,
					InvoiceDate = new DateTime(2017, 7, 1),
					DueDate = new DateTime(2018, 7, 1),
					IsPaid = null }
			};

			List<Invoice> filteredList = invoiceList.Where(i => i.CustomerId == customerId).ToList();

			return filteredList;
		}
	}
}
