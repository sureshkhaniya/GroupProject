using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Search
{
    internal class clsSearchSQL
    {

        public string GetAllInvoices()
        {
            return "SELECT * FROM Invoices";
        }

        public string GetInvoiceByNumber(int invoiceNum)
        {
            return $"SELECT * FROM Invoices WHERE InvoiceNum = {invoiceNum}";
        }

        public string GetInvoiceByNumberAndDate(int invoiceNum, string date)
        {
            return $"SELECT * FROM Invoices WHERE InvoiceNum = {invoiceNum} AND InvoiceDate = #{date}#";
        }

        public string GetInvoiceByNumberDateAndTotal(int invoiceNum, string date, decimal totalCost)
        {
            return $"SELECT * FROM Invoices WHERE InvoiceNum = {invoiceNum} AND InvoiceDate = #{date}# AND TotalCost = {totalCost}";
        }

        public string GetDistinctInvoiceNums()
        {
            return "SELECT DISTINCT(InvoiceNum) FROM Invoices ORDER BY InvoiceNum";
        }

        public string GetDistinctInvoiceDates()
        {
            return "SELECT DISTINCT(InvoiceDate) FROM Invoices ORDER BY InvoiceDate";
        }

        public string GetDistinctTotalCosts()
        {
            return "SELECT DISTINCT(TotalCost) FROM Invoices ORDER BY TotalCost";
        }

    }
}
