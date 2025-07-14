using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Common;

namespace GroupProject.Items
{
    internal class clsItemsLogic
    {
        //getAllItems return List<clsItem>
        //AddItem(clsItem)
        //EditItem(clsItem clsOldItem, clsIteam clsNewItem)
        //DeleteItem(clsItem clsItemtoDelete)
        //IsItemonInvoice(clsItem)

        // Returns all items from ItemDesc table
        public List<clsItem> GetAllItems() {
            /* implementation to use SQL and return items */
            
            return new List<clsItem>(); }


        // Adds an item to ItemDesc table
        public void AddItem(clsItem item) { /* implementation here */ }
        // Edits an item in ItemDesc table
        public void EditItem(clsItem oldItem, clsItem newItem) {
            /* implementation here */ 
        
        }


        // Deletes an item from ItemDesc table
        public void DeleteItem(clsItem itemToDelete) { 
            /* implementation here */ }
        // Checks if item is used in any invoice (LineItems)

        public bool IsItemOnInvoice(clsItem item) { 
            /* implementation here */ 
            return false; }
    

}
}
