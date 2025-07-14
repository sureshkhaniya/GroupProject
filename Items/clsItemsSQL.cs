using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Items
{
    internal class clsItemsSQL
    {
        /// <summary>
        /// Gets all items from ItemDesc table.
        /// </summary>
        public string GetAllItems()
        {
            return "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc";
        }

        /// <summary>
        /// Adds a new item to ItemDesc.
        /// </summary>
        public string AddItem(string code, string desc, decimal cost)
        {
            return $"INSERT INTO ItemDesc (ItemCode, ItemDesc, Cost) VALUES ('{code}', '{desc}', {cost})";
        }

        /// <summary>
        /// Updates an item in ItemDesc.
        /// </summary>
        public string EditItem(string code, string desc, decimal cost)
        {
            return $"UPDATE ItemDesc SET ItemDesc = '{desc}', Cost = {cost} WHERE ItemCode = '{code}'";
        }

        /// <summary>
        /// Deletes an item from ItemDesc.
        /// </summary>
        public string DeleteItem(string code)
        {
            return $"DELETE FROM ItemDesc WHERE ItemCode = '{code}'";
        }

        /// <summary>
        /// Checks if an item is on any invoice.
        /// </summary>
        public string IsItemOnInvoice(string code)
        {
            return $"SELECT DISTINCT(InvoiceNum) FROM LineItems WHERE ItemCode = '{code}'";
        }


    }
}
