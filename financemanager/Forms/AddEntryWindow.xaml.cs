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

namespace financemanager
{
    /// <summary>
    /// Interaktionslogik für AddEntryWindow.xaml
    /// </summary>
    public partial class AddEntryWindow : Window
    {

        public EventHandler<EventArgStringList> AddEntryEvent;
        public AddEntryWindow()
        {
            InitializeComponent();
            entryFormatComboBox.SelectedItem = CSVComboBoxItem;
        
        }

        private void addEntryButton_Click(object sender, RoutedEventArgs e)
        {
            EventArgStringList newStringEventArg = new EventArgStringList();
            if (string.IsNullOrEmpty(entryNameBox.Text)) { return; }
            List<string> argList = new List<string>();
            argList.Add(entryNameBox.Text);
            Console.WriteLine(entryFormatComboBox.SelectedItem.ToString());
            argList.Add(entryFormatComboBox.SelectionBoxItem.ToString());
            newStringEventArg.arg = argList;
            AddEntryEvent?.Invoke(this, newStringEventArg);
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
