using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Common
{
    internal class clsInvoice
    {
        //Invoice Number
        //Invoice Date
        //Total Cost
        //List<clsItems>

        // Invoice Number
        public int InvoiceNum { get; set; }
        // Invoice Date
        public string InvoiceDate { get; set; }
        // Total Cost
        public decimal TotalCost { get; set; }
        // List of items on invoice
        public List<clsItem> Items { get; set; }
    }
}
