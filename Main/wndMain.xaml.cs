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
using System.IO;
using System.Data.OleDb;


namespace GroupProject.Main
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        public wndMain()
        {
            InitializeComponent();
        }
    }

    //After search window is closed, check property selectedInvoiceID in the search
    //window to see if an invoice was selected. If so, load the invoice into the main window.

    //After  Items window is closedm check property bHasItemsBeenChanged in the Items window to see if items have been changed/updated. if so reload items in combo box.

}
