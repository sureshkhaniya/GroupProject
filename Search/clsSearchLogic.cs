using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Common;

namespace GroupProject.Search
{
    internal class clsSearchLogic
    {

        //GetDistinctInvoiceNumber
        //GetDistinctDate
        //GetDistinctCosts
        //GetInvoices(InvoiceNumber,InvoiceDate, TotalCost) - returns List<clsInvoices>

        // Returns distinct invoice numbers for dropdown
        public List<int> GetDistinctInvoiceNumber() { /* implementation */ return new List<int>(); }
        // Returns distinct dates for dropdown
        public List<string> GetDistinctDate() { /* implementation */ return new List<string>(); }
        // Returns distinct total costs for dropdown
        public List<decimal> GetDistinctCosts() { /* implementation */ return new List<decimal>(); }
        // Returns list of invoices matching search criteria
        public List<clsInvoice> GetInvoices(int? invoiceNumber, string invoiceDate, decimal? totalCost) { /* implementation */ return new List<clsInvoice>(); }
    }


}
}
