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
    public partial class OpenProjectsWindow : Window
    {
        public EventHandler<EventArgString> OpenProjectEvent;
        public OpenProjectsWindow(List<string> projects)
        {
            InitializeComponent();
            foreach(string i  in projects) {
                projectslistbox.Items.Add(i);
                Console.WriteLine(i);
            }
            
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            object selecteditem = projectslistbox.SelectedItem;
            if(selecteditem == null) { return; }
            EventArgString eArg = new EventArgString();
            eArg.arg = selecteditem.ToString();
            OpenProjectEvent?.Invoke(this, eArg);
            this.Close();
        }
    }
}
