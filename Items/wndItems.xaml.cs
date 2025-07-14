using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GroupProject.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        public wndItems()
        {
            InitializeComponent();

        }

        // Property to indicate if items have been changed (used by main window to know if refresh needed)
        public bool HasItemsBeenChanged { get; set; } = false;

        //bool bHasItemsBeenChanged;  //set to true when an item has been added/edited/deleted. used by main window to know if needs to refresh items list
        //bool HasItemsBeenChanged; //property
    }
}
