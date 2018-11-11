namespace InvoiceTotal
{
	partial class FormInvoiceTotal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
			this.textBoxDiscountPercent = new System.Windows.Forms.TextBox();
			this.textBoxSubtotal = new System.Windows.Forms.TextBox();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelDiscountAmount = new System.Windows.Forms.Label();
			this.labelDiscountPercent = new System.Windows.Forms.Label();
			this.labelSubtotal = new System.Windows.Forms.Label();
			this.buttonClearTotals = new System.Windows.Forms.Button();
			this.textBoxSmallestInvoice = new System.Windows.Forms.TextBox();
			this.textBoxLargestInvoice = new System.Windows.Forms.TextBox();
			this.labelSmallestInvoice = new System.Windows.Forms.Label();
			this.labelLargestInvoice = new System.Windows.Forms.Label();
			this.textBoxInvoiceAverage = new System.Windows.Forms.TextBox();
			this.textBoxTotalOfInvoices = new System.Windows.Forms.TextBox();
			this.textBoxNumberOfInvoices = new System.Windows.Forms.TextBox();
			this.labelInvoiceAverage = new System.Windows.Forms.Label();
			this.labelTotalOfInvoices = new System.Windows.Forms.Label();
			this.labelNumberOfInvoices = new System.Windows.Forms.Label();
			this.labelCustomerType = new System.Windows.Forms.Label();
			this.comboBoxCustomerType = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(197, 326);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 13;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(12, 326);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 11;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(169, 116);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotal.TabIndex = 17;
			this.textBoxTotal.TabStop = false;
			// 
			// textBoxDiscountAmount
			// 
			this.textBoxDiscountAmount.Location = new System.Drawing.Point(169, 89);
			this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
			this.textBoxDiscountAmount.ReadOnly = true;
			this.textBoxDiscountAmount.Size = new System.Drawing.Size(100, 20);
			this.textBoxDiscountAmount.TabIndex = 16;
			this.textBoxDiscountAmount.TabStop = false;
			// 
			// textBoxDiscountPercent
			// 
			this.textBoxDiscountPercent.Location = new System.Drawing.Point(169, 62);
			this.textBoxDiscountPercent.Name = "textBoxDiscountPercent";
			this.textBoxDiscountPercent.ReadOnly = true;
			this.textBoxDiscountPercent.Size = new System.Drawing.Size(100, 20);
			this.textBoxDiscountPercent.TabIndex = 15;
			this.textBoxDiscountPercent.TabStop = false;
			// 
			// textBoxSubtotal
			// 
			this.textBoxSubtotal.Location = new System.Drawing.Point(169, 35);
			this.textBoxSubtotal.Name = "textBoxSubtotal";
			this.textBoxSubtotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxSubtotal.TabIndex = 9;
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(12, 116);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(34, 13);
			this.labelTotal.TabIndex = 14;
			this.labelTotal.Text = "Total:";
			this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDiscountAmount
			// 
			this.labelDiscountAmount.AutoSize = true;
			this.labelDiscountAmount.Location = new System.Drawing.Point(12, 89);
			this.labelDiscountAmount.Name = "labelDiscountAmount";
			this.labelDiscountAmount.Size = new System.Drawing.Size(90, 13);
			this.labelDiscountAmount.TabIndex = 12;
			this.labelDiscountAmount.Text = "Discount amount:";
			this.labelDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDiscountPercent
			// 
			this.labelDiscountPercent.AutoSize = true;
			this.labelDiscountPercent.Location = new System.Drawing.Point(12, 62);
			this.labelDiscountPercent.Name = "labelDiscountPercent";
			this.labelDiscountPercent.Size = new System.Drawing.Size(91, 13);
			this.labelDiscountPercent.TabIndex = 10;
			this.labelDiscountPercent.Text = "Discount percent:";
			this.labelDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.Location = new System.Drawing.Point(12, 35);
			this.labelSubtotal.Name = "labelSubtotal";
			this.labelSubtotal.Size = new System.Drawing.Size(49, 13);
			this.labelSubtotal.TabIndex = 8;
			this.labelSubtotal.Text = "&Subtotal";
			this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonClearTotals
			// 
			this.buttonClearTotals.Location = new System.Drawing.Point(105, 326);
			this.buttonClearTotals.Name = "buttonClearTotals";
			this.buttonClearTotals.Size = new System.Drawing.Size(75, 23);
			this.buttonClearTotals.TabIndex = 18;
			this.buttonClearTotals.Text = "Clear Totals";
			this.buttonClearTotals.UseVisualStyleBackColor = true;
			this.buttonClearTotals.Click += new System.EventHandler(this.buttonClearTotals_Click);
			// 
			// textBoxSmallestInvoice
			// 
			this.textBoxSmallestInvoice.Location = new System.Drawing.Point(169, 237);
			this.textBoxSmallestInvoice.Name = "textBoxSmallestInvoice";
			this.textBoxSmallestInvoice.ReadOnly = true;
			this.textBoxSmallestInvoice.Size = new System.Drawing.Size(100, 20);
			this.textBoxSmallestInvoice.TabIndex = 31;
			// 
			// textBoxLargestInvoice
			// 
			this.textBoxLargestInvoice.Location = new System.Drawing.Point(169, 213);
			this.textBoxLargestInvoice.Name = "textBoxLargestInvoice";
			this.textBoxLargestInvoice.ReadOnly = true;
			this.textBoxLargestInvoice.Size = new System.Drawing.Size(100, 20);
			this.textBoxLargestInvoice.TabIndex = 30;
			// 
			// labelSmallestInvoice
			// 
			this.labelSmallestInvoice.AutoSize = true;
			this.labelSmallestInvoice.Location = new System.Drawing.Point(12, 237);
			this.labelSmallestInvoice.Name = "labelSmallestInvoice";
			this.labelSmallestInvoice.Size = new System.Drawing.Size(84, 13);
			this.labelSmallestInvoice.TabIndex = 29;
			this.labelSmallestInvoice.Text = "Smallest Invoice";
			// 
			// labelLargestInvoice
			// 
			this.labelLargestInvoice.AutoSize = true;
			this.labelLargestInvoice.Location = new System.Drawing.Point(12, 213);
			this.labelLargestInvoice.Name = "labelLargestInvoice";
			this.labelLargestInvoice.Size = new System.Drawing.Size(80, 13);
			this.labelLargestInvoice.TabIndex = 28;
			this.labelLargestInvoice.Text = "Largest Invoice";
			// 
			// textBoxInvoiceAverage
			// 
			this.textBoxInvoiceAverage.Location = new System.Drawing.Point(169, 189);
			this.textBoxInvoiceAverage.Name = "textBoxInvoiceAverage";
			this.textBoxInvoiceAverage.ReadOnly = true;
			this.textBoxInvoiceAverage.Size = new System.Drawing.Size(100, 20);
			this.textBoxInvoiceAverage.TabIndex = 27;
			// 
			// textBoxTotalOfInvoices
			// 
			this.textBoxTotalOfInvoices.Location = new System.Drawing.Point(169, 165);
			this.textBoxTotalOfInvoices.Name = "textBoxTotalOfInvoices";
			this.textBoxTotalOfInvoices.ReadOnly = true;
			this.textBoxTotalOfInvoices.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalOfInvoices.TabIndex = 26;
			// 
			// textBoxNumberOfInvoices
			// 
			this.textBoxNumberOfInvoices.Location = new System.Drawing.Point(169, 141);
			this.textBoxNumberOfInvoices.Name = "textBoxNumberOfInvoices";
			this.textBoxNumberOfInvoices.ReadOnly = true;
			this.textBoxNumberOfInvoices.Size = new System.Drawing.Size(100, 20);
			this.textBoxNumberOfInvoices.TabIndex = 25;
			// 
			// labelInvoiceAverage
			// 
			this.labelInvoiceAverage.AutoSize = true;
			this.labelInvoiceAverage.Location = new System.Drawing.Point(12, 189);
			this.labelInvoiceAverage.Name = "labelInvoiceAverage";
			this.labelInvoiceAverage.Size = new System.Drawing.Size(85, 13);
			this.labelInvoiceAverage.TabIndex = 24;
			this.labelInvoiceAverage.Text = "Invoice Average";
			// 
			// labelTotalOfInvoices
			// 
			this.labelTotalOfInvoices.AutoSize = true;
			this.labelTotalOfInvoices.Location = new System.Drawing.Point(12, 165);
			this.labelTotalOfInvoices.Name = "labelTotalOfInvoices";
			this.labelTotalOfInvoices.Size = new System.Drawing.Size(88, 13);
			this.labelTotalOfInvoices.TabIndex = 23;
			this.labelTotalOfInvoices.Text = "Total Of Invoices";
			// 
			// labelNumberOfInvoices
			// 
			this.labelNumberOfInvoices.Location = new System.Drawing.Point(12, 141);
			this.labelNumberOfInvoices.Name = "labelNumberOfInvoices";
			this.labelNumberOfInvoices.Size = new System.Drawing.Size(104, 13);
			this.labelNumberOfInvoices.TabIndex = 22;
			this.labelNumberOfInvoices.Text = "Number of Invoices";
			// 
			// labelCustomerType
			// 
			this.labelCustomerType.Location = new System.Drawing.Point(12, 9);
			this.labelCustomerType.Name = "labelCustomerType";
			this.labelCustomerType.Size = new System.Drawing.Size(94, 20);
			this.labelCustomerType.TabIndex = 32;
			this.labelCustomerType.Text = "Customer type:";
			this.labelCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxCustomerType
			// 
			this.comboBoxCustomerType.FormattingEnabled = true;
			this.comboBoxCustomerType.Location = new System.Drawing.Point(169, 9);
			this.comboBoxCustomerType.Name = "comboBoxCustomerType";
			this.comboBoxCustomerType.Size = new System.Drawing.Size(100, 21);
			this.comboBoxCustomerType.TabIndex = 34;
			// 
			// FormInvoiceTotal
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 361);
			this.Controls.Add(this.comboBoxCustomerType);
			this.Controls.Add(this.labelCustomerType);
			this.Controls.Add(this.textBoxSmallestInvoice);
			this.Controls.Add(this.textBoxLargestInvoice);
			this.Controls.Add(this.labelSmallestInvoice);
			this.Controls.Add(this.labelLargestInvoice);
			this.Controls.Add(this.textBoxInvoiceAverage);
			this.Controls.Add(this.textBoxTotalOfInvoices);
			this.Controls.Add(this.textBoxNumberOfInvoices);
			this.Controls.Add(this.labelInvoiceAverage);
			this.Controls.Add(this.labelTotalOfInvoices);
			this.Controls.Add(this.labelNumberOfInvoices);
			this.Controls.Add(this.buttonClearTotals);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.textBoxTotal);
			this.Controls.Add(this.textBoxDiscountAmount);
			this.Controls.Add(this.textBoxDiscountPercent);
			this.Controls.Add(this.textBoxSubtotal);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.labelDiscountAmount);
			this.Controls.Add(this.labelDiscountPercent);
			this.Controls.Add(this.labelSubtotal);
			this.Name = "FormInvoiceTotal";
			this.Text = "Invoice Total";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxDiscountAmount;
		private System.Windows.Forms.TextBox textBoxDiscountPercent;
		private System.Windows.Forms.TextBox textBoxSubtotal;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelDiscountAmount;
		private System.Windows.Forms.Label labelDiscountPercent;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.Button buttonClearTotals;
		private System.Windows.Forms.TextBox textBoxSmallestInvoice;
		private System.Windows.Forms.TextBox textBoxLargestInvoice;
		private System.Windows.Forms.Label labelSmallestInvoice;
		private System.Windows.Forms.Label labelLargestInvoice;
		private System.Windows.Forms.TextBox textBoxInvoiceAverage;
		private System.Windows.Forms.TextBox textBoxTotalOfInvoices;
		private System.Windows.Forms.TextBox textBoxNumberOfInvoices;
		private System.Windows.Forms.Label labelInvoiceAverage;
		private System.Windows.Forms.Label labelTotalOfInvoices;
		private System.Windows.Forms.Label labelNumberOfInvoices;
		private System.Windows.Forms.Label labelCustomerType;
		private System.Windows.Forms.ComboBox comboBoxCustomerType;
	}
}

