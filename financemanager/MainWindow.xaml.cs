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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace financemanager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Year_Button_Click(object sender, RoutedEventArgs e)
        {
            ItemDialog addYearDialog = new ItemDialog();
            addYearDialog.Show();
        }

        private void Remove_Year_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Year_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}