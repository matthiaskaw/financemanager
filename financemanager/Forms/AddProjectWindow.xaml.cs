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
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class AddProjectWindow : Window
    {
        public EventHandler<EventArgString> AddProjectEvent;
        public AddProjectWindow()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            EventArgString eventarg = new EventArgString();
            eventarg.arg = ProjectTextBox.Text;
            AddProjectEvent?.Invoke(this, eventarg);

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        



    }
}

