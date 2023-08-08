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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace financemanager
{
    /// <summary>
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class CloseButton : UserControl
    {
        public event EventHandler Click;

        public CloseButton()
        {
            InitializeComponent();
        }


        private void tableCloseButton_Click(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }

        }
    }

    class CloseableTab : TabItem
    {
        public CloseableTab(String headerName) {
            
            CloseButton closeButton = new CloseButton();
            TextBlock headerText = new TextBlock();

            headerText.Text = headerName;
            DockPanel dockPanel = new DockPanel();
            dockPanel.Children.Add(headerText);
            closeButton.Click +=
                (sender, e) =>
                {
                    var tabControl = Parent as ItemsControl;
                    tabControl.Items.Remove(this);
                };
            dockPanel.Children.Add(closeButton);

            // Set the header
            Header = dockPanel;

        }
    }
}
