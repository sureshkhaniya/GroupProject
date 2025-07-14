﻿using System;
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

namespace GroupProject.Search
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {
        public wndSearch()
        {
            InitializeComponent();
        }
        public int SelectedInvoiceID { get; set; } = 0;
    }


    //SelectedInvoiceID - Holds the invoice ID if the user selected one, and zero if no invoice selected.
    //SelectedInvoiceID - property main window can acess to get the selected invoice ID.
}
