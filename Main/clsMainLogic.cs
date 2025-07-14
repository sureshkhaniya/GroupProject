using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Common;

namespace GroupProject.Main
{
    internal class clsMainLogic
    {

        //getAllItems returns List<clsItem>
        //SaveNewInvoice(clsInvoice)
        //EditInvoice(clsOldInvoice, clsNewInvoice)
        //getInvoice(Invoicenumber returns clsInvoice - Get the invoice and items for the selected invoice for search window.


        // Returns all items from ItemDesc table
        public List<clsItem> GetAllItems() {
            /* implementation to use SQL and return items */ 
            
            return new List<clsItem>(); }
        
        
        // Saves new invoice (calls SQL to insert)
        public void SaveNewInvoice(clsInvoice invoice) {
            /* implementation here */ 
        
        }
        // Edits an invoice
        public void EditInvoice(clsInvoice oldInvoice, clsInvoice newInvoice) {
            
            
            /* implementation here */ }
        // Gets invoice and items for a given InvoiceNum (used when selecting from search)
        public clsInvoice GetInvoice(int invoiceNumber) {
            
            /* implementation here */
            
            return new clsInvoice(); }



    }
}
