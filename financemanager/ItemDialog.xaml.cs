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

namespace financemanager
{
    /// <summary>
    /// Interaktionslogik für ItemDialog.xaml
    /// </summary>
    public partial class ItemDialog : Window
    {
        public ItemDialog()
        {
            InitializeComponent();
        }
        public void AddContent(string contentname){
            TextBox newText = new TextBox();
            newText.Text = contentname;
            this.mainGrid.Children.Add(newText);
        }
        
        private void Add_Item_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Item_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public partial class AddItemDialog : ItemDialog {
        public AddItemDialog() {
            InitializeComponent();
        }
    }

    
}
