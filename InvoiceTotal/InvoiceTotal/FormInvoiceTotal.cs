using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvoiceTotal
{
	public partial class FormInvoiceTotal : Form
	{
		private const string PERCENT_FORMAT_STRING = "p1";

		private const string CURRENCY_FORMAT_STRING = "c";

		private const string College = "College";

		private const string Retail = "Retail";

		private const string Trade = "Trade";

		private SortedList<decimal, decimal> sortedInvoiceTotals;

		public FormInvoiceTotal()
		{
			this.InitializeComponent();
			this.comboBoxCustomerType.Items.Add(FormInvoiceTotal.College);
			this.comboBoxCustomerType.Items.Add(FormInvoiceTotal.Retail);
			this.comboBoxCustomerType.Items.Add(FormInvoiceTotal.Trade);
			this.sortedInvoiceTotals = new SortedList<decimal, decimal>();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			string customerType;
			decimal invoiceSubtotal;
			decimal discountPercent = 0m;
			decimal discountAmount;
			decimal invoiceTotal;

			try
			{
				if(this.textBoxSubtotal.Text != "")
				{
					customerType = this.comboBoxCustomerType.Text;
					invoiceSubtotal = Convert.ToDecimal(this.textBoxSubtotal.Text);
					if(invoiceSubtotal > 0 && invoiceSubtotal < 10000)
					{
						switch(customerType)
						{
							case FormInvoiceTotal.Retail:
								if(invoiceSubtotal < 100)
								{
									discountPercent = .0m;
								}
								else if(invoiceSubtotal >= 100 && invoiceSubtotal < 250)
								{
									discountPercent = .25m;
								}
								else if(invoiceSubtotal >= 250)
								{
									discountPercent = .3m;
								}
								break;
							case FormInvoiceTotal.College:
								discountPercent = .2m;
								break;
							case FormInvoiceTotal.Trade:
								if(invoiceSubtotal < 500)
								{
									discountPercent = .4m;
								}
								else
								{
									discountPercent = .5m;
								}
								break;
							default:
								discountPercent = .1m;
								break;
						}

						discountAmount = invoiceSubtotal * discountPercent;
						invoiceTotal = invoiceSubtotal - discountAmount;
						this.sortedInvoiceTotals.Add(invoiceTotal, invoiceTotal);

						this.textBoxDiscountPercent.Text = discountPercent.ToString(FormInvoiceTotal.PERCENT_FORMAT_STRING);
						this.textBoxDiscountAmount.Text = discountAmount.ToString(FormInvoiceTotal.CURRENCY_FORMAT_STRING);
						this.textBoxTotal.Text = invoiceTotal.ToString(FormInvoiceTotal.CURRENCY_FORMAT_STRING);

						this.textBoxNumberOfInvoices.Text = this.sortedInvoiceTotals.Count.ToString();
						this.textBoxTotalOfInvoices.Text = this.sortedInvoiceTotals.Keys.Aggregate(0m, (x, y) => x + y).ToString(FormInvoiceTotal.CURRENCY_FORMAT_STRING);
						this.textBoxInvoiceAverage.Text = (this.sortedInvoiceTotals.Keys.Aggregate(0m, (x, y) => x + y) / this.sortedInvoiceTotals.Count).ToString(FormInvoiceTotal.CURRENCY_FORMAT_STRING);
						this.textBoxLargestInvoice.Text = this.sortedInvoiceTotals.Keys.Max().ToString(FormInvoiceTotal.CURRENCY_FORMAT_STRING);
						this.textBoxSmallestInvoice.Text = this.sortedInvoiceTotals.Keys.Min().ToString(FormInvoiceTotal.CURRENCY_FORMAT_STRING);

						this.textBoxSubtotal.Focus();
					}
					else
					{
						MessageBox.Show("The subtotal field should be between 0 and 10,000 exclusive.", "Entry Error");
					}
				}
				else
				{
					MessageBox.Show("The subtotal field should not be empty.", "Entry Error");
				}
			}
			catch(FormatException)
			{
				MessageBox.Show("Please enter a valid number for the Subtotal field.", "Entry Error");
			}
			catch(Exception)
			{

				MessageBox.Show("Please enter a valid number for the subtotal field.", "Entry Error");
			}
		}

		private void buttonClearTotals_Click(object sender, EventArgs e)
		{
			this.sortedInvoiceTotals.Clear();

			this.textBoxNumberOfInvoices.Text = "";
			this.textBoxTotalOfInvoices.Text = "";
			this.textBoxInvoiceAverage.Text = "";
			this.textBoxLargestInvoice.Text = "";
			this.textBoxSmallestInvoice.Text = "";

			this.textBoxSubtotal.Focus();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			StringBuilder listOutput = new StringBuilder();
			foreach(KeyValuePair<decimal, decimal> invoice in this.sortedInvoiceTotals)
			{
				listOutput.Append(invoice.Key).Append(Environment.NewLine);
			}
			MessageBox.Show(listOutput.ToString(), "Order Totals");
			base.Close();
		}
	}
}
